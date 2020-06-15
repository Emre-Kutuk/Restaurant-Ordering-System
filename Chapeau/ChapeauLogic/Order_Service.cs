using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class Order_Service
    {
        private Order_DAO order_db = new Order_DAO();

        public void AddOrder(RestaurantTable table, Employee employee, List<OrderItem> orderItemList)
        {
            try
            {
                order_db.Db_Add_Order(table, employee, orderItemList);
            }
            catch (Exception e)
            {
                throw new Exception("Chapeau application couldn't connect to the database. Therefore we cannot add the orders data.");
            }
        }

        public List<OrderItem> GetKitchen() // fetch kitchen order items
        {
            try
            {
                List<OrderItem> items = order_db.Db_Get_Kitchen_view();
                return items;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<OrderItem> GetBar() // fetch bar order items
        {
            try
            {
                List<OrderItem> items = order_db.Db_BarView();
                return items;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void MarkReady(int id) // remove from order list
        {
            try
            {
                order_db.Order_Item_Ready(id);
            }
            catch (Exception e)
            {
                throw new Exception("could not mark order ready");
            }
        }

        public Order Db_Get_Orders_Of_Specific_Table(int tableNumber)
        {
            try
            {
                return order_db.Db_Get_Orders_Of_Specific_Table(tableNumber);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private bool CheckVat(OrderItem orderitem)
        {
            try
            {
                return order_db.CheckVat(orderitem);
            }
            catch (Exception e)
            {
                throw new Exception("Chapeau application couldn't connect to the database. Therefore we can't retrieve the order data.");
            }
        }

        //To complete an order, table needs to be set free and payment needs to be completed. Two methods are combined, thats why they're together in here
        public void CompleteOrder(Order order)
        {
            try
            {
                order_db.CompleteOrder(order);
            }
            catch (Exception e)
            {
                throw new Exception("Chapeau application couldn't connect to the database. Therefore we can't register your payment.");
            }
        }

        //Checks VAT and calculates the price according to that
        public decimal CalculateVAT(Order order)
        {
            decimal VAT = 0;
            foreach (OrderItem orderItem in order.OrderItemList)
            {
                if (CheckVat(orderItem))
                {
                    //alcohol 21
                    VAT += (orderItem.MenuItem.Price * (decimal)0.21) * orderItem.Count;
                }
                else
                {
                    //normal 6
                    VAT += (orderItem.MenuItem.Price * (decimal)0.06) * orderItem.Count;
                }
            }

            return VAT;
        }
    }
}
