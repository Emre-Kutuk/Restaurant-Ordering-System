using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI.Pages
{
    public partial class EmployeeAdd : Form
    {
        ChapeauLogic.Employee_Service employee_service = new ChapeauLogic.Employee_Service();
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            //check to see if any boxes are left empty
            if (AddName_txt.Text == "" || AddPassword_txt.Text == "" || AddRole_txt.Text == "")
            {
                MessageBox.Show("Please Enter All Details");
            }
            else
            {
                //adding an employee
                List<Employee> employeesList = employee_service.GetEmployee_List();
                string name = AddName_txt.Text;
                //check to see if name already exists
                foreach (Employee ee in employeesList)
                {
                    if (ee.EmployeeName == name)
                    {
                        MessageBox.Show("name already exists");
                        return;
                    }
                }
                //storing info 
                int password = int.Parse(AddPassword_txt.Text);
                int role = Get_Role(AddRole_txt.Text);
                // calling addemployee method
                employee_service.AddEmployee(name, password, role);
                MessageBox.Show("Employee added");
            }
        }
        //btn to return to employee list
        private void btn_EmployeeList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //getting employee role
        private int Get_Role(string input)
        {
            int role;
            if (input == "Waiter")
                role = 1;
            else if (input == "Barman")
                role = 2;
            else if (input == "Chef")
                role = 3;
            else if (input == "Manager")
                role = 4;
            else
            {
                MessageBox.Show("Wrong role");
                return -1;
            }
            return role;
        }
    }
}
