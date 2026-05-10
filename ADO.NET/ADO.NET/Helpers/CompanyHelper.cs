using ADO.NET.Data;
using ADO.NET.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO.NET.Helpers
{
    public static class CompanyHelper
    {
        public static List<SelectListItem> ListCompanies => ListAll().Select(x => new SelectListItem() { Text = x.Name, Value = x.CompanyId.ToString() }).Prepend(new SelectListItem() { Text = "-- Select Company --", Value = "" }).ToList();

        private static List<CompanyDTO> ListAll()
        {
            var list = new List<CompanyDTO>();
            using(var c = new CompanyContext())
            {
                list = c.ListCompanies(getAll: true);
            }
            return list;
        }
    }
}