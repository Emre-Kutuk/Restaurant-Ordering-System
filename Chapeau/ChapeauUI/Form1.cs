using ChapeauLogic;
using ChapeauModel;
using ChapeauUI.Pages;
using ChapeauUserControl.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class Form1 : Form
    {
        public Employee employee;
        public Form1()
        {
            InitializeComponent();

            CheckBox checkBox = new CheckBox();
            checkBox1.Appearance = Appearance.Button;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void Verify()
        {
            if (usernameinput.Text == "" || passwordinput.Text == "")
            {
                usernametest.Text = "Please enter something";
                return;
            }

            Employee_Service employee_service = new Employee_Service();
            Employee employee = employee_service.GetEmployee(usernameinput.Text, int.Parse(passwordinput.Text));

            if (employee != null)
            {
                ShowCorrectPage(employee);
                usernameinput.Text = "";
                passwordinput.Text = "";
            }
            else
            {
                usernametest.Text = "Wrong username or password";

                passwordinput.Text = "";
            }

        }

        private void ShowCorrectPage(Employee employee)
        {
            if (employee.Role == RestaurantRole.Waiter)
            {
                Overview overviewForm = new Overview(employee);
                overviewForm.Show();
            } else if (employee.Role == RestaurantRole.Barman || employee.Role == RestaurantRole.Chef)
            {
                OrderForwarding OrderForwardingForm = new OrderForwarding(employee);
                OrderForwardingForm.Show();
            } else if (employee.Role == RestaurantRole.Manager)
            {
                Employee_Edit employeeForm = new Employee_Edit();
                employeeForm.Show();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Verify();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordinput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordinput.UseSystemPasswordChar = true;
            }
        }
    }
}
