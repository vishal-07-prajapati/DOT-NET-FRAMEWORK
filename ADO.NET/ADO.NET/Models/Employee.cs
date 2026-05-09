using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET.Models
{
    public class Employee
    {
        public Employee() { }
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
    }
}
