using ADO.NET.Data;
using ADO.NET.DTO;
using ADO.NET.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Service
{
    public class CompanyService
    {
        private readonly CompanyRepo _company;
        public CompanyService(CompanyRepo company)
        {
            _company = company;
        }

        public List<CompanyDTO> GetAll() => _company.GetAll();

        public CompanyDTO GetById(int id) => _company.GetById(id);

        public CompanyDTO InsertUpdate(CompanyDTO company) => _company.InsertUpdate(company);
    }
}