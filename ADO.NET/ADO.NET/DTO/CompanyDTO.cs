using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADO.NET.DTO
{
    public class CompanyDTO
    {
        public int CompanyId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Musr Enter Company Name")]
        public string Name { get; set; }
        public bool IsDelete { get; set; }
    }
}