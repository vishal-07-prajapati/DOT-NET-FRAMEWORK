using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADO.NET.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must Select the Company.")]
        public int CompanyId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must Enter First Name")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must Must Enter Last Name")]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must Enter Email Address")]
        [EmailAddress(ErrorMessage = "Must enter valid Email Address.")]
        public string Email { get; set; }
        public bool IsDelete { get; set; }
    }
}