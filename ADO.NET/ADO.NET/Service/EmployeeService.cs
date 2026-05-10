using ADO.NET.DTO;
using ADO.NET.Models;
using ADO.NET.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Service
{
    public class EmployeeService
    {
        private readonly EmployeeRepo _employee;
        public EmployeeService(EmployeeRepo employee) 
        {
            _employee = employee;
        }

        public List<EmployeeDTO> GetAll(bool isTest = false) => _employee.GetAll();
        public EmployeeDTO GetById(int id) => _employee.GetById(id);
        public EmployeeDTO InsertUpdate(EmployeeDTO employeeDTO) => _employee.InsertUpdate(employeeDTO);
    }
}