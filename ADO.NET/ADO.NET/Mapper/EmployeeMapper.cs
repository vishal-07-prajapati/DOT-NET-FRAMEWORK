using ADO.NET.DTO;
using ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Mapper
{
    public static class EmployeeMapper
    {
        public static EmployeeDTO ToDTO(this Employee e) =>
            new EmployeeDTO()
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                CompanyId = e.CompanyId,
                Email = e.Email,
                IsDelete = e.IsDelete,
            };

        public static Employee ToModel(this EmployeeDTO e) =>
            new Employee()
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                CompanyId = e.CompanyId,
                Email = e.Email,
                IsDelete = e.IsDelete,
            };
        public static List<EmployeeDTO> ToDTO(this IQueryable<Employee> employees) => employees.Select(e => new EmployeeDTO()
        {
            EmployeeId = e.EmployeeId,
            FirstName = e.FirstName,
            LastName = e.LastName,
            CompanyId = e.CompanyId,
            Email = e.Email,
            IsDelete = e.IsDelete,
        }).ToList();
    }
}