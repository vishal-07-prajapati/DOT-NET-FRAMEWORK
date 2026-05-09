using ADO.NET.Interface;
using ADO.NET.Models;
using ADO.NET.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET.Repo
{
    public class EmployeeRepo: IEmployee
    {
        public List<Employee> GetAll() => EmployeeUtility.GetFakeEmployeesList(); // need to change after adding logic of db
        public List<Employee> GetFakeEmployeesList() => EmployeeUtility.GetFakeEmployeesList();
    }
}
