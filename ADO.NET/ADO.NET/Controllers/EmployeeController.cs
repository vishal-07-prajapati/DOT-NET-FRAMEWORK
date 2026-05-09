using ADO.NET.Repo;
using System.Web.Mvc;

namespace ADO.NET.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepo _employee;

        public EmployeeController(EmployeeRepo employee)
        {
            _employee = employee;
        }

        public ActionResult Index(bool isTest = false)
        {
            ViewBag.Title = "Home Page";
            var employeeList = isTest ? _employee.GetFakeEmployeesList() : _employee.GetAll();
            return View(employeeList);
        }
    }
}
