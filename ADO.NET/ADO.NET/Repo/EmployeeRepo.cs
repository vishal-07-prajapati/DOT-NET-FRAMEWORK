using ADO.NET.Data;
using ADO.NET.DTO;
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
        private readonly EmployeeContext _employee;
        public EmployeeRepo(EmployeeContext employee) => _employee = employee;

        public List<EmployeeDTO> GetAll() => _employee.ListEmployees(); // need to change after adding logic of db
        public EmployeeDTO InsertUpdate(EmployeeDTO employee) => _employee.InsertUpdate(employee);
        public EmployeeDTO GetById(int id) => _employee.GetById(id);
    }
}   
