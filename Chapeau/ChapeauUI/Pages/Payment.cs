using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI.Pages
{
    public partial class Payment : Form
    {
        private RestaurantTable table;
        private Order order;
        private Order_Service os;
        private Employee employee;

        //Form is being initialized with the table number, so orders of that table can be displayed
        public Payment(RestaurantTable table, Employee employee)
        {
            InitializeComponent();
            this.table = table;
            this.employee = employee;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            os = new Order_Service();
            navigation.Hide();

            initOrderItems();
        }

        private void initOrderItems()
        {
            order = os.Db_Get_Orders_Of_Specific_Table(table.TableId);

            DisplayOrderItems(order);
            DisplayValues(order);
        }

        //Displays the order items for a specific order in a list view
        private void DisplayOrderItems(Order order)
        {
            listPayment.Clear();

            ColumnHeader Name = new ColumnHeader();
            Name.Text = "Name";

            ColumnHeader Count = new ColumnHeader();
            Count.Text = "Count";

            ColumnHeader Price = new ColumnHeader();
            Price.Text = "Price";

            listPayment.Columns.AddRange(new ColumnHeader[] { Name, Count, Price });

            //Checks every orderitem for an order
            foreach (OrderItem orderItem in order.OrderItemList)
            {
                ListViewItem li = new ListViewItem(orderItem.MenuItem.Name);
                li.SubItems.Add(orderItem.Count.ToString());
                li.SubItems.Add("€ " + (orderItem.Count * orderItem.MenuItem.Price).ToString("0.00"));

                listPayment.Items.Add(li);
            }

            listPayment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Handles the labels
        private void DisplayValues(Order order)
        {
            lblPayment.Text = "Payment Table: " + table.TableId.ToString();
            lblPrice.Text = "€ " + order.CalculateTotalPrice().ToString("0.00");
            lblVAT.Text = "€ " + os.CalculateVAT(order).ToString("0.00");
            lblTotalWithVat.Text = "€ " + (order.CalculateTotalPrice() + os.CalculateVAT(order)).ToString("0.00");
        }

        //Completes the payment, checkout
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Price * count + VAT calculation is happening here
            order.TotalCost = order.CalculateTotalPrice() + os.CalculateVAT(order);

            //If the input is not a number, it goes as 0 to the DB
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxTip.Text, @"^-?(([1-9]\d*)|0)(.0*[1-9](0*[1-9])*)?$"))
                order.Tip = 0;
            else
                order.Tip = decimal.Parse(txtBoxTip.Text);
            
            //Saves the comment
            order.Feedback = txtBoxComment.Text;

            os.CompleteOrder(order);

            //Shows Payment was successfull message
            MessageBox.Show("Payment was succesfully completed.", "Payment Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Overview overview = new Overview(employee);
            overview.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Overview overview = new Overview(employee);
            overview.Show();
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

        private void Refreshview_Click(object sender, EventArgs e)
        {
            initOrderItems();
        }
    }
}
