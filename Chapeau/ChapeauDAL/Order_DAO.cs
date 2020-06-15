using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class Order_DAO : Base
    {
        /*
         * Check if there is an order for a specific table that is not yet payed,
         * And return the id of the order
        */
        public int Db_Get_Table_OrderId(int tableNumber)
        {
            string query = "SELECT [order_id] FROM [Order] WHERE table_number = @table_number AND is_payed = 0";
            SqlParameter[] sqlParameters = new SqlParameter[1]{
                new SqlParameter("@table_number", tableNumber)
            };

            return ReadOrderFromTableId(ExecuteSelectQuery(query, sqlParameters));
        }
        // Get the order id of a table, if it exists, otherwise return 0
        private int ReadOrderFromTableId(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                return (int)dr["order_id"];
            }

            return 0;
        }
        public void Db_Add_Order(RestaurantTable table, Employee employee, List<OrderItem> orderItemList)
        {
            // Get id of the order based on the table number
            int orderMainId = Db_Get_Table_OrderId(table.TableId);

            // If the orderMainId is 0, then there is not an order for that table in the database
            if (orderMainId == 0)
            {
                // Add a new order to the database and return the auto_incremented primary key value of it
                orderMainId = Db_Add_New_Order(table, employee);
            }

            /*
             * When we add the order items to the database we also need to deduct it from the stock.
             * 
             * We use a SqlTransaction for it, to be able to sent the items to thet database in bulk,
             * and cancel the transaction when an error occurs.
            */
            SqlConnection conn = OpenConnection();
            SqlTransaction transaction = conn.BeginTransaction();

            Db_Add_Order_Items(orderMainId, orderItemList, transaction);
            Db_Deduct_Item_Stock(orderItemList, transaction);

            // Commit all the items to the database
            transaction.Commit();

            // Close connection
            conn.Close();
        }

        // Add new order to database
        private int Db_Add_New_Order(RestaurantTable table, Employee employee)
        {
            string query = @"
                INSERT INTO [Order] (table_number, employee_id, total_cost, tip, is_payed, feedback) 
                    VALUES(@table_number, @employee_id, 0, 0, 0, '') SELECT SCOPE_IDENTITY();";

            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@table_number", table.TableId),
                new SqlParameter("@employee_id", employee.EmployeeId)
            };

            int autoIncrementId = ExecuteEditQueryAutoIncrement(query, sqlParameters);

            return autoIncrementId;
        }

        // Add all ordered items to the database
        private void Db_Add_Order_Items(int OrderMainId, List<OrderItem> orderItemList, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO [order_item] (order_id, menu_item_id, order_status, time_order_taken, count, comment) 
                    VALUES(@order_id, @menu_item_id, @order_status, @time_order_taken, @count, @comment);";

            try
            {
                foreach (OrderItem item in orderItemList)
                {
                    SqlParameter[] sqlParameters = new SqlParameter[6]
                    {
                        new SqlParameter("@order_id", OrderMainId),
                        new SqlParameter("@menu_item_id", item.MenuItem.ItemId),
                        new SqlParameter("@order_status", item.Status),
                        new SqlParameter("@time_order_taken", item.Time),
                        new SqlParameter("@count", item.Count),
                        new SqlParameter("@comment", item.Comment)
                    };

                    ExecuteEditTranQuery(query, sqlParameters, transaction);
                }
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new Exception(e.Message);
            }
        }

        // Deduct the stock of a menu item based on the ordered item and the count of it
        private void Db_Deduct_Item_Stock(List<OrderItem> orderItemList, SqlTransaction transaction)
        {
            string query = @"UPDATE Menu_Item SET [stock] = [stock] - @ordered_item_count WHERE [menu_item_id] = @item_id;";

            try
            {
                foreach (OrderItem item in orderItemList)
                {
                    SqlParameter[] sqlParameters = new SqlParameter[2]
                    {
                        new SqlParameter("@ordered_item_count", item.Count),
                        new SqlParameter("@item_id", item.MenuItem.ItemId),
                    };

                    ExecuteEditTranQuery(query, sqlParameters, transaction);
                }
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new Exception(e.Message);
            }
        }
        //Gets the unpaid orders for specific tableNumber
        public Order Db_Get_Orders_Of_Specific_Table(int tableNumber)
        {

            string query = @"
                SELECT DISTINCT [Order].order_id, [Order].table_number, [Restaurant_Table].number_of_seats,
				[Restaurant_Table].is_occupied, [Order].employee_id, [Employee].[name], [Employee].[password],
				[Employee].[role],[Order].is_payed, [Order].tip, [Order].total_cost, [Order].feedback 
                FROM [Order] INNER JOIN Restaurant_Table
                ON [Order].table_number = Restaurant_Table.table_number 
                INNER JOIN Employee ON [Order].employee_id = Employee.employee_id
                INNER JOIN [Order_Item] ON [Order].order_id = [Order_Item].order_id
                WHERE [Order].table_number = @table_number
                AND [Order].is_payed = 0";

            SqlParameter[] sqlParameters = new SqlParameter[1]{
                new SqlParameter("@table_number", tableNumber)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        //Reads a single order and returns Order
        private Order ReadTable(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                RestaurantTable table = new RestaurantTable(
                    (int)dr["table_number"],
                    (bool)dr["is_occupied"],
                    (int)dr["number_of_seats"]
                );

                Employee employee = new Employee(
                    (int)dr["employee_id"],
                    dr["name"].ToString(),
                    (int)dr["role"],
                    (int)dr["password"]
                );

                Order order = new Order(
                    (int)dr["order_id"],
                    table,
                    employee,
                    Get_OrderItem_By_OrderID((int)(dr["order_id"])),
                    (bool)dr["is_payed"],
                    (decimal)dr["tip"],
                    (decimal)dr["total_cost"],
                    (string)dr["feedback"]);

                return order;
            }

            return null;
        }

        public List<OrderItem> Db_BarView() // query to get all drink orders that are not ready
        {
            string query = @"
                             SELECT *
	                        FROM Order_Item AS OI
	                        JOIN [Order] AS O
	                        ON OI.order_id = O.order_id
	                        JOIN Menu_Item AS MI
	                        ON OI.menu_item_id = MI.menu_item_id
	                        WHERE MI.menu_categorie_id >6 AND OI.order_status = 1;";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_items(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> Db_Get_Kitchen_view()//query to get all food orders that are not ready
        {
            string query = @"
                             SELECT *
	                        FROM Order_Item AS OI
	                        JOIN [Order] AS O
	                        ON OI.order_id = O.order_id
	                        JOIN Menu_Item AS MI
	                        ON OI.menu_item_id = MI.menu_item_id
	                        WHERE MI.menu_categorie_id <7 AND OI.order_status = 1;";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_items(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadTables_items(DataTable dataTable) //reading tables for menu item queries
        {
            List<OrderItem> items = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem(
                    (int)dr["menu_item_id"],
                    (int)dr["menu_categorie_id"],
                    (string)dr["item_name"],
                    (decimal)dr["price"],
                    (int)dr["stock"]);
                OrderItem orderItem = new OrderItem(
                    menuItem,
                    (int)dr["count"],
                    (string)dr["comment"],
                    (OrderStatus)dr["order_status"],
                    (DateTime)dr["time_order_taken"],
                    (int)dr["order_item_id"]);
                {
                    orderItem.Table = (int)dr["table_number"];
                }
                items.Add(orderItem);
            }
            return items;
        }

        public void Order_Item_Ready(int order_item_id) // for marking an order ready
        {
            string query = "UPDATE Order_Item SET [order_status]=2 WHERE order_item_id=@order_item_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "order_item_id";
            sqlParameters[0].Value = order_item_id;
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RestaurantTable table = new RestaurantTable(
                    (int)dr["table_number"],
                    (bool)dr["is_reserved"],
                    (int)dr["number_of_seats"]
                );

                Employee employee = new Employee(
                    (int)dr["employee_id"],
                    dr["name"].ToString(),
                    (int)dr["role"],
                    (int)dr["password"]
                );

                Order order = new Order(
                    (int)dr["order_id"],
                    table,
                    employee,
                    Get_OrderItem_By_OrderID((int)(dr["order_id"])),
                    (bool)dr["is_payed"],
                    (decimal)dr["tip"],
                    (decimal)dr["total_cost"],
                    (string)dr["feedback"]
                );

                orders.Add(order);
            }
            return orders;
        }

        //Gets the list of order items for single order
        private List<OrderItem> Get_OrderItem_By_OrderID(int order_id)
        {
            List<OrderItem> order_items = new List<OrderItem>();

            string query = @"SELECT * FROM [Order_Item] 
			                INNER JOIN [Menu_Item] ON [Order_Item].menu_item_id = [Menu_Item].menu_item_id
			                WHERE [Order_Item].order_id = @order_id";

            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("@order_id", order_id) };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem(
                    new MenuItem(
                        (int)dr["menu_item_id"],
                        (int)dr["menu_categorie_id"],
                        (string)dr["item_name"],
                        (decimal)dr["price"],
                        (int)dr["stock"]
                    ),
                    (int)dr["count"],
                    (string)dr["comment"],
                    (OrderStatus)dr["order_status"],
                    (DateTime)dr["time_order_taken"],
                    (int)dr["order_item_id"]
                );

                order_items.Add(orderItem);
            }
            return order_items;
        }

        //Checks the VAT of specific order item, returns bool
        public bool CheckVat(OrderItem orderitem)
        {
            string query = @"SELECT Menu_Categories.VAT FROM Menu_Item
                            INNER JOIN Menu_Categories 
                            ON Menu_Item.menu_categorie_id = Menu_Categories.menu_categorie_id 
                            WHERE Menu_Item.menu_item_id = @menuitemid";

            SqlParameter[] sqlParameters = new SqlParameter[1]{
                    new SqlParameter("@menuitemid", orderitem.MenuItem.ItemId)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (((bool)dataTable.Rows[0][0] == false))
                return false;
            else
                return true;
        }

        //Transaction is being used here, so that two queries can be sent together if one fails, the other one fails as well
        public void CompleteOrder(Order order)
        {
            SqlConnection conn = OpenConnection();
            SqlTransaction transaction = conn.BeginTransaction();

            CompletePayment(order, transaction);
            SetTableFree(order.Table, transaction);

            transaction.Commit();

            conn.Close();

        }

        //Completes the payment, enters the price, tip, feedback and changes order to paid
        private void CompletePayment(Order order, SqlTransaction transaction)
        {
            string query = @"UPDATE [Order] SET total_cost = @totalcost, tip = @tip, feedback = @comment, is_payed = 1
					         WHERE [Order].order_id = @orderid";

            SqlParameter[] sqlParameters = new SqlParameter[4] {
                    new SqlParameter("@totalcost", order.TotalCost),
                    new SqlParameter("@tip", order.Tip),
                    new SqlParameter("@comment", order.Feedback),
                    new SqlParameter("@orderid", order.OrderId)
            };

            ExecuteEditTranQuery(query, sqlParameters, transaction);
        }

        //Changes the table from occupied to free
        private void SetTableFree(RestaurantTable table, SqlTransaction transaction)
        {
            string query = @"UPDATE [Restaurant_Table] SET is_occupied = 0
                            WHERE [Restaurant_Table].table_number = @table_number";

            SqlParameter[] sqlParameters = new SqlParameter[1] {
                        new SqlParameter("@table_number", table.TableId)};

            ExecuteEditTranQuery(query, sqlParameters, transaction);
        }
    }
}
