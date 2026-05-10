using ADO.NET.DTO;
using ADO.NET.Repo;
using ADO.NET.Service;
using System.Web.Mvc;

namespace ADO.NET.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employee;

        public EmployeeController(EmployeeService employee)
        {
            _employee = employee;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var employeeList = _employee.GetAll();
            return View(employeeList);
        }

        public ActionResult AddEdit(int id = 0) => View(_employee.GetById(id));
        [HttpPost]
        public ActionResult AddEdit(EmployeeDTO model)
        {
            if (ModelState.IsValid) 
            {
               model = _employee.InsertUpdate(model);
            }
            return View(model);
        }
    }
}
