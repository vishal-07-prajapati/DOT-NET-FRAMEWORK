using ADO.NET.DTO;
using ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Mapper
{
    public static class CompanyMapper
    {
        public static CompanyDTO ToDTO(this Company c) =>
            new CompanyDTO()
            {
                CompanyId = c.CompanyId,
                Name = c.Name,
                IsDelete = c.IsDelete,
            };

        public static Company ToModel(this CompanyDTO c) =>
            new Company()
            {
                CompanyId = c.CompanyId,
                Name = c.Name,
                IsDelete = c.IsDelete,
            };
        public static List<CompanyDTO> ToDTO(this IQueryable<Company> companies) => companies.Select(c => new CompanyDTO()
        {
            CompanyId = c.CompanyId,
            Name = c.Name,
            IsDelete = c.IsDelete,
        }).ToList();
    }
}