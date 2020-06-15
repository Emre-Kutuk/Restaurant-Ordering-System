using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChapeauUI.Pages
{
    public partial class OrderForwarding : Form
    {
        private ChapeauLogic.Order_Service orderService = new ChapeauLogic.Order_Service();
        private ChapeauModel.OrderItem selected_items;
        private Employee employee;
        public OrderForwarding(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            InitOrderPanels();

            navigation.Hide();
        }

        private void InitOrderPanels()
        {
            if (employee.Role == RestaurantRole.Chef)
            {
                KitchenPanel("Kitchen");
            }
            else
            {
                BarPanel("Bar");
            }
        }

        private void KitchenPanel(string name)
        {
            if (name == "Kitchen")
            {
                // Change navigation item states to correspond with correct panel
                navitem_dishes.ItemActiveState = true;
                navitem_drinks.ItemActiveState = false;
                //hide other panels
                pnl_bar.Hide();
                //show kitchen panel
                pnl_kitchen.Show();
                //clear listview
                listView_kitchenview.Clear();
                //list to get all drinks
                List<OrderItem> orderItems = orderService.GetKitchen();

                //add columns to listview
                listView_kitchenview.Columns.Add("Item Name");
                listView_kitchenview.Columns.Add("Table Nr");
                listView_kitchenview.Columns.Add("Order Time");
                listView_kitchenview.Columns.Add("Count");
                listView_kitchenview.Columns.Add("Comments");
                //Add items to the listview
                foreach (OrderItem i in orderItems)
                {
                    string[] items = new string[]
                    {
                        i.MenuItem.Name.ToString(),
                        i.Table.ToString(),
                        i.Time.TimeOfDay.ToString("hh\\:mm\\:ss"),
                        i.Count.ToString(),
                        i.Comment.ToString(),
                    };
                    ListViewItem list = new ListViewItem(items);
                    list.Tag = i;
                    listView_kitchenview.Items.Add(list);
                }
            }
            listView_kitchenview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_kitchenview.Show();
        }

        private void BarPanel(string input)
        {
            if (input == "Bar")
            {
                navitem_dishes.ItemActiveState = false;
                navitem_drinks.ItemActiveState = true;
                //hide other panels
                pnl_kitchen.Hide();
                //show bar panel
                pnl_bar.Show();
                //clear listview
                listView_Barview.Clear();
                //list to get all drinks
                List<OrderItem> items = orderService.GetBar();

                //add columns to listview
                listView_Barview.Columns.Add("Drink Name");
                listView_Barview.Columns.Add("Table Nr");
                listView_Barview.Columns.Add("Order Time");
                listView_Barview.Columns.Add("Count");
                listView_Barview.Columns.Add("Comments");
                //Add items to the listview
                foreach (OrderItem i in items)
                {
                    string[] drinks = new string[]
                    {
                        i.MenuItem.Name.ToString(),
                        i.Table.ToString(),
                        i.Time.TimeOfDay.ToString("hh\\:mm\\:ss"),
                        i.Count.ToString(),
                        i.Comment.ToString(),
                    };
                    ListViewItem list = new ListViewItem(drinks);
                    list.Tag = i;
                    listView_Barview.Items.Add(list);
                }
                listView_Barview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listView_Barview.Show();
            }
        }

        private void btn_ready_Click(object sender, EventArgs e) // Marking / Sending Off The Selected Food Ready
        {
            if (listView_kitchenview.SelectedItems.Count > 0)
            {
                orderService.MarkReady(selected_items.Order_itemid);
                MessageBox.Show("Item Ready");
                KitchenPanel("Kitchen");
            }
            else
            {
                MessageBox.Show("Please select an item"); // If no item is selected error message is shown.
            }
        }

        private void btn_viewBar_Click(object sender, EventArgs e) // Switch To Drink Forwarding. 
        {
            BarPanel("Bar");
        }

        private void btn_Food_Click(object sender, EventArgs e) // Switch To Food Forwarding.
        {
            KitchenPanel("Kitchen");
        }

        private void btn_Drink_Ready_Click(object sender, EventArgs e) // Marking / Sending Off The Selected Drink Ready
        {
            if (listView_Barview.SelectedItems.Count > 0)
            {
                orderService.MarkReady(selected_items.Order_itemid);
                MessageBox.Show("Item Ready");
                BarPanel("Bar");
            }
            else
            {
                MessageBox.Show("Please select an item"); // If no item is selected error message is shown.
            }
        }

        private void listView_kitchenview_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (listView_kitchenview.SelectedItems.Count > 0)
            {
                selected_items = (ChapeauModel.OrderItem)listView_kitchenview.SelectedItems[0].Tag;
            }
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

        private void navitem_drinks_Click(object sender, EventArgs e)
        {
            BarPanel("Bar");
            navigation.Hide();
        }

        private void navitem_dishes_Click(object sender, EventArgs e)
        {
            KitchenPanel("Kitchen");
            navigation.Hide();
        }

        private void Refreshview_Click(object sender, EventArgs e)
        {
            InitOrderPanels();
        }

        private void listView_Barview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Barview.SelectedItems.Count > 0)
            {
                selected_items = (ChapeauModel.OrderItem)listView_Barview.SelectedItems[0].Tag;
            }
        }
    }
}