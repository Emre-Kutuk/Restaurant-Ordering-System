using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class Employee_Service
    {
        private Employee_DAO employee_db = new Employee_DAO();
        private Employee employee;
        public Employee GetEmployee(string name, int password)
        {
            try
            {
                employee = employee_db.Db_Get_Employee(name, password);
                return employee;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Employee> GetEmployee_List()
        { // to return a list of all employees
            try
            {
                List<Employee> employee = employee_db.Db_Get_Employee_List();
                return employee;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateEmployee(int employee_id, string name, int password, int role) // used to update employees
        {
            try
            {
                employee_db.Update(employee_id, name, password, role);
            }
            catch (Exception e)
            {
                throw new Exception("Could not update Employee");
            }
        }
        public void AddEmployee(string name, int password, int role) // used to addemployee 
        {
            try
            {
                employee_db.Insert(name, password, role);
            }
            catch (Exception e)
            {
                throw new Exception("Could not add new Employee");
            }
        }
        public void DeleteEmployee(string name) // used to call delete method from dao
        {
            try
            {
                employee_db.Delete(name);
            }
            catch (Exception e)
            {
                throw new Exception("Could not delete Employee");
            }
        }
    }
}
