using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public RestaurantRole Role { get; set; }
        public int Password { get; set; }

        public Employee(int employeeId, string employeeName, int role, int password)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Role = (RestaurantRole)role;
            Password = password;
        }
    }
}
