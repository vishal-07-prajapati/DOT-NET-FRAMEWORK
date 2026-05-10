using ADO.NET.DTO;
using ADO.NET.Mapper;
using ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ADO.NET.Data
{
    public class CompanyContext: AppDbContext
    {
        public CompanyContext() { }

        public List<CompanyDTO> ListCompanies(int page = 1, int pageSize = 10, bool getAll = false) 
        { 
            var list = new List<CompanyDTO>();
            using (var conext = new CompanyContext())
            {
                var companies = conext.Companies.AsNoTracking().OrderBy(x => x.Name);
                
                if (getAll)
                    list = companies.ToDTO();
                else
                    list = companies.Skip((page - 1) * pageSize).Take(pageSize).ToDTO();

            }
            return list;
        }

        public CompanyDTO GetById(int id)
        {
            var company = new CompanyDTO();
            if(id > 0)
            {
                using (var context = new CompanyContext())
                {
                    company = context.Companies.FirstOrDefault(x => x.CompanyId == id).ToDTO();
                }
            }
            return company;
        }

        public CompanyDTO InsertUpdate(CompanyDTO company)
        {
            using (var context = new EmployeeContext())
            {
                Company model = company.ToModel();

                if (model.CompanyId == 0)
                    context.Companies.Add(model);
                else
                    context.Entry(model).State = EntityState.Modified;

                context.SaveChanges();
                company = model.ToDTO();
            }
            return company;
        }
    }
}