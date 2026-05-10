using ADO.NET.DTO;
using ADO.NET.Mapper;
using ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ADO.NET.Data
{
    public class EmployeeContext : AppDbContext
    {
        public EmployeeContext() { }

        public List<EmployeeDTO> ListEmployees(int page = 1, int pageSize = 10)
        {
            var list = new List<EmployeeDTO>();
            using (var conext = new EmployeeContext())
            {
                list = conext.Employees.AsNoTracking().OrderBy(x => x.EmployeeId).Skip((page - 1) * pageSize).Take(pageSize).ToDTO();
            }
            return list;
        }

        public EmployeeDTO GetById(int id)
        {
            var employee = new EmployeeDTO();

            if (id > 0)
            {
                using (var conext = new EmployeeContext())
                {
                    employee = conext.Employees.FirstOrDefault(x => x.EmployeeId == id).ToDTO();
                }
            }
            return employee;
        }

        public EmployeeDTO InsertUpdate(EmployeeDTO employee)
        {
            using (var context = new EmployeeContext())
            {
                Employee model = employee.ToModel();

                if (model.EmployeeId == 0)
                    context.Employees.Add(model);
                else
                    context.Entry(model).State = EntityState.Modified;

                context.SaveChanges();

                employee = model.ToDTO();
            }
            return employee;
        }
    }
}