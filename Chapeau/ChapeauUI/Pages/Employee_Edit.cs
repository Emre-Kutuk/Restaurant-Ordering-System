using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChapeauUI.Pages
{
    public partial class Employee_Edit : Form
    {
        private ChapeauLogic.Employee_Service employee_service = new ChapeauLogic.Employee_Service();
        private Employee employee_selected;

        public Employee_Edit()
        {
            InitializeComponent();
            DisplayEmployees();

            navigation.Hide();
        }

        private void DisplayEmployees()
        {
            //getting list of employees
            List<Employee> employeesList = employee_service.GetEmployee_List();
            listEmployees.Clear();
            listEmployees.Columns.Add("Name");
            listEmployees.Columns.Add("Password");
            listEmployees.Columns.Add("Role");
            foreach (Employee ee in employeesList)
            {
                string[] employees = new string[]
                {
                    ee.EmployeeName.ToString(),
                        ee.Password.ToString(),
                        ee.Role.ToString(),
                };
                ListViewItem li = new ListViewItem(employees);
                li.Tag = ee;
                listEmployees.Items.Add(li);
            }
            listEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            name_txt.Clear();
            password_txt.Clear();
            role_txt.Text = "";
        }

        private void btn_deleteEmployee_Click(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItems.Count > 0)
            {
                //delete employee
                employee_service.DeleteEmployee(employee_selected.EmployeeName);
                //reload list
                DisplayEmployees();
            }
            else
            {
                MessageBox.Show("Select Employee");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItems.Count > 0)
            {
                //set according to updated version
                employee_selected.EmployeeName = name_txt.Text;
                employee_selected.Password = int.Parse(password_txt.Text);
                employee_selected.Role = (RestaurantRole)Get_Role(role_txt.Text);
                //update employee in the database
                employee_service.UpdateEmployee(employee_selected.EmployeeId,
                    employee_selected.EmployeeName,
                    employee_selected.Password,
                    (int)employee_selected.Role);
                //reload the list of employees
                DisplayEmployees();
            }
            else
            {
                MessageBox.Show("Select Employee");
            }
        }

        private int Get_Role(string role)
        {
            //get role as an int/enum
            int roleno;
            if (role == "Waiter")
                roleno = 1;
            else if (role == "Barman")
                roleno = 2;
            else if (role == "Chef")
                roleno = 3;
            else if (role == "Manager")
                roleno = 4;
            else
            {
                MessageBox.Show("Wrong role");
                return -1;
            }
            return roleno;
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            //opens up adding employee page
            EmployeeAdd addemployee = new EmployeeAdd();
            addemployee.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //refresh
            DisplayEmployees();
        }

        private void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItems.Count > 0)
            {
                //making sure the selected items are stored
                employee_selected = (Employee)listEmployees.SelectedItems[0].Tag;
                //displaying the items in text boxes
                name_txt.Text = employee_selected.EmployeeName.ToString();
                password_txt.Text = employee_selected.Password.ToString();
                role_txt.Text = employee_selected.Role.ToString();
            }
        }

        private void navigationItem1_Click(object sender, EventArgs e)
        {
            MenuEdit edit = new MenuEdit();
            edit.Show();

            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            navigation.Hide();
        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {
            navigation.Show();
        }
    }
}