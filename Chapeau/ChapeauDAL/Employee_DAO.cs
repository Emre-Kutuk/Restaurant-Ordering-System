using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class Employee_DAO : Base
    {
        public Employee Db_Get_Employee(string name, int password)
        {
            string query = "SELECT * FROM Employee WHERE [name] = @name AND [password] = @password";
            SqlParameter[] sqlParameters = new SqlParameter[2]{
                new SqlParameter("@name", name),
                new SqlParameter("@password", password)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadTable(DataTable dataTable)
        {
            Employee employee;

            foreach (DataRow row in dataTable.Rows)
            {
                return employee = new Employee((int)row["employee_id"], row["name"].ToString(), (int)row["role"], (int)row["password"]);
            }

            return null;
        }
        public List<Employee> Db_Get_Employee_List() // gets list of all employees
        {
            string query = "SELECT * FROM Employee";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable_List(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTable_List(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee(
                    (int)dr["employee_id"],
                    dr["name"].ToString(),
                    (int)dr["role"],
                    (int)dr["password"]
                    );
                employees.Add(employee);
            }
            return employees;
        }
        public void Insert(string name, int password, int role) // method for adding employee
        {
            // @ gets the values passed
            string query = "INSERT INTO Employee ([name],[password],[role]) VALUES(@name,@password,@role)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[1] = new SqlParameter();
            sqlParameters[2] = new SqlParameter();
            sqlParameters[0].ParameterName = "name";
            sqlParameters[0].Value = name;
            sqlParameters[1].ParameterName = "password";
            sqlParameters[1].Value = password;
            sqlParameters[2].ParameterName = "role";
            sqlParameters[2].Value = role;
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Delete(string name) // method for deleting employees
        {

            string query = "DELETE FROM Employee WHERE [name] =@name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "name";
            sqlParameters[0].Value = name;
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Update(int employee_id, string name, int password, int role) // method for updating employee
        {
            string query = "UPDATE Employee SET [name]=@name,[password] = @password,[role]=@role WHERE employee_id=@employee_id";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[1] = new SqlParameter();
            sqlParameters[2] = new SqlParameter();
            sqlParameters[3] = new SqlParameter();
            sqlParameters[0].ParameterName = "employee_id";
            sqlParameters[0].Value = employee_id;
            sqlParameters[1].ParameterName = "name";
            sqlParameters[1].Value = name;
            sqlParameters[2].ParameterName = "password";
            sqlParameters[2].Value = password;
            sqlParameters[3].ParameterName = "role";
            sqlParameters[3].Value = role;
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
