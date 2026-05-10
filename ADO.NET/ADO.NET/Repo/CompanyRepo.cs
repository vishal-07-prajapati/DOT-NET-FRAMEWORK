using ADO.NET.Data;
using ADO.NET.DTO;
using ADO.NET.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Repo
{
    public class CompanyRepo : ICompany
    {
        private readonly CompanyContext _company;
        public CompanyRepo(CompanyContext company)
        {
            _company = company;
        }

        public List<CompanyDTO> GetAll() =>_company.ListCompanies();

        public CompanyDTO GetById(int id) => _company.GetById(id);

        public CompanyDTO InsertUpdate(CompanyDTO company) => _company.InsertUpdate(company);
    }
}