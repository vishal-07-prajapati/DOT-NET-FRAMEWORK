using ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO.NET.Utility
{
    public static class EmployeeUtility
    {
        // if want to add some common logic between projects / solution you can manage here
        private static readonly List<Employee> FakeEmployees = new List<Employee>()
        {
            new Employee(){ EmployeeId = 1, CompanyId = 1, Email = "1@gmail.com", FirstName = "1", LastName = "1" }, 
            new Employee(){ EmployeeId = 2, CompanyId = 2, Email = "2@gmail.com", FirstName = "2", LastName = "2" }, 
            new Employee(){ EmployeeId = 3, CompanyId = 3, Email = "3@gmail.com", FirstName = "3", LastName = "3" }, 
            new Employee(){ EmployeeId = 4, CompanyId = 4, Email = "4@gmail.com", FirstName = "4", LastName = "4" }, 
            new Employee(){ EmployeeId = 5, CompanyId = 5, Email = "5@gmail.com", FirstName = "5", LastName = "5" }, 
            new Employee(){ EmployeeId = 6, CompanyId = 6, Email = "6@gmail.com", FirstName = "6", LastName = "6" }, 
            new Employee(){ EmployeeId = 7, CompanyId = 7, Email = "7@gmail.com", FirstName = "7", LastName = "7" }, 
            new Employee(){ EmployeeId = 8, CompanyId = 8, Email = "8@gmail.com", FirstName = "8", LastName = "8" }, 
            new Employee(){ EmployeeId = 9, CompanyId = 9, Email = "9@gmail.com", FirstName = "9", LastName = "9" },
            new Employee(){ EmployeeId = 10, CompanyId = 10, Email = "10@gmail.com", FirstName = "10", LastName = "10" } 
        };
        public static List<Employee> GetFakeEmployeesList() => FakeEmployees.ToList();
        public static List<Employee> GetFakeEmployeesList(int employeeId) => FakeEmployees.Where(x => x.EmployeeId == employeeId).ToList();
    }
}
