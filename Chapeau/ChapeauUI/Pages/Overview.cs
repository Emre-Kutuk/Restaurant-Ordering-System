using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChapeauUI.Pages
{
    public partial class Overview : Form
    {
        private Order_Service order_service;
        private RestaurantTables_Service table_service;
        List<RestaurantTable> tables;
        private RestaurantTable selectedTable;
        private Employee employee;
        public Overview(Employee employee)
        {
            InitializeComponent();
            order_service = new Order_Service();
            table_service = new RestaurantTables_Service();
            tables = new List<RestaurantTable>();
            this.employee = employee;

            btn_takeorder.Enabled = false;
            btn_takepayment.Enabled = false;
            
            navigation.Hide();

            GetSetformation();
        }

        private void GetSetformation()
        {
            Button[] butts = new Button[10] { Table1, Table2, Table3, Table4, Table5, Table6, Table7, Table8, Table9, Table10 };
            Label[] labels = new Label[10] { Status1, Status2, Status3, Status4, Status5, Status6, Status7, Status8, Status9, Status10 };
            Button[] occupyButtonList = new Button[10] { Occupy1, Occupy2, Occupy3, Occupy4, Occupy5, Occupy6, Occupy7, Occupy8, Occupy9, Occupy10 };

            tables = table_service.GetRestaurantTables();

            for (int x = 0; x < tables.Count; x++)
            {
                labels[x].ForeColor = tables[x].IsOccupied ? System.Drawing.Color.DarkGray : System.Drawing.Color.DarkOrange;
                occupyButtonList[x].Enabled = !tables[x].IsOccupied;
                labels[x].Text = tables[x].IsOccupied ? "Occupied" : "Free";
            } // by default

            for (int tableNr = 0; tableNr <= labels.Length + 1; tableNr++) // looping to check all order from table list one by one
            {
                Order order = order_service.Db_Get_Orders_Of_Specific_Table(tableNr + 1); //filling the list

                if (order != null)
                {
                    bool isFinished = order.OrderItemList.Any(item => item.Status == OrderStatus.Finished);
                    bool orderTaken = order.OrderItemList.Any(item => item.Status != OrderStatus.Finished);

                    if (isFinished)
                    {
                        labels[tableNr].Text = "Order is ready";
                        labels[tableNr].ForeColor = System.Drawing.Color.Green;
                    }

                    if (orderTaken)
                    {
                        labels[tableNr].Text = "Order taken";
                        labels[tableNr].ForeColor = System.Drawing.Color.Black;
                    }
                }
            }    
        }

        private void Buttons(int TableNumber)
        {
            Displaylistview.Items.Clear();
            DateTime Now = DateTime.Now;
            Order order = order_service.Db_Get_Orders_Of_Specific_Table(TableNumber); //filling the list

            int tableIndex = TableNumber - 1;
            selectedTable = tables[tableIndex];

            btn_takeorder.Enabled = selectedTable.IsOccupied;

            if (order != null)
            {
                foreach (OrderItem item in order.OrderItemList) //setting status 
                {
                    ListViewItem Display = new ListViewItem(order.Table.TableId.ToString());

                    OrderStatus status = item.Status;
                    Display.SubItems.Add(status.ToString());
                    Display.SubItems.Add(item.Time.ToString("HH:mm:ss"));
                    Display.SubItems.Add(item.MenuItem.Name);
                    Display.SubItems.Add(item.Count.ToString());
                    Displaylistview.Items.Add(Display);

                    TimeSpan value = item.Time.Subtract(Now); //substracting now from database time
                    time.Text = "Order was taken: " + value.ToString(@"hh\:mm\:ss") + " ago";

                }
                if (order.OrderItemList.Any(item => item.Status == OrderStatus.Taken))
                {
                    btn_takepayment.Enabled = false;
                } else
                {
                    btn_takepayment.Enabled = true;
                }
            }
        }
    
        private void Occupy(int tableNumber)
        {
            table_service.OccupyTable(tableNumber);
            GetSetformation();
        }
        private void Refreshview_Click(object sender, EventArgs e)
        {
            GetSetformation();
        }
        private void btn_takeorder_Click(object sender, EventArgs e)
        {
            TakeOrder takeOrder = new TakeOrder(employee, selectedTable);
            takeOrder.Show();

            this.Close();
        }

        private void btn_takepayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(selectedTable, employee);
            payment.Show();

            this.Close();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbl_menu_Click(object sender, EventArgs e)
        {
            navigation.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            navigation.Hide();
        }

        private void Table1_Click(object sender, EventArgs e)
        {

            Buttons(1);
        }

        private void Table2_Click(object sender, EventArgs e)
        {

            Buttons(2);
        }

        private void Table3_Click(object sender, EventArgs e)
        {

            Buttons(3);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            Buttons(4);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            Buttons(5);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            Buttons(6);
        }

        private void Table7_Click(object sender, EventArgs e)
        {
            Buttons(7);
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            Buttons(8);
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            Buttons(9);
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            Buttons(10);
        }

        private void Occupy1_Click(object sender, EventArgs e)
        {
            Occupy(1);
        }

        private void Occupy2_Click(object sender, EventArgs e)
        {
            Occupy(2);
        }

        private void Occupy3_Click(object sender, EventArgs e)
        {
            Occupy(3);
        }

        private void Occupy4_Click(object sender, EventArgs e)
        {
            Occupy(4);
        }

        private void Occupy5_Click(object sender, EventArgs e)
        {
            Occupy(5);
        }

        private void Occupy6_Click(object sender, EventArgs e)
        {
            Occupy(6);
        }

        private void Occupy7_Click(object sender, EventArgs e)
        {
            Occupy(7);
        }

        private void Occupy8_Click(object sender, EventArgs e)
        {
            Occupy(8);
        }

        private void Occupy9_Click(object sender, EventArgs e)
        {
            Occupy(9);
        }

        private void Occupy10_Click(object sender, EventArgs e)
        {
            Occupy(10);
        }
    }
}