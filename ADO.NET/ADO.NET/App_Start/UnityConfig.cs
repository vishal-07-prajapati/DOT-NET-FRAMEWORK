using ADO.NET.Interface;
using ADO.NET.Models;
using ADO.NET.Repo;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ADO.NET
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<IEmployee, EmployeeRepo>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}