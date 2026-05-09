using ADO.NET.Models;
using ADO.NET.Helpers.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET.Interface
{
    public interface IEmployee : GenericInterface<Employee>
    {
        // see i didn't add any listing code here.
        List<Employee> GetFakeEmployeesList();
    }
}
