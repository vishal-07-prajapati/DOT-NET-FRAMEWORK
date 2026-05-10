using ADO.NET.DTO;
using ADO.NET.Repo;
using ADO.NET.Service;
using System.Web.Mvc;

namespace ADO.NET.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyService _company;

        public CompanyController(CompanyService company)
        {
            _company = company;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var companyList = _company.GetAll();
            return View(companyList);
        }

        public ActionResult AddEdit(int id = 0) => View(_company.GetById(id));

        [HttpPost]
        public ActionResult AddEdit(CompanyDTO model)
        {
            if (ModelState.IsValid)
            {
              model = _company.InsertUpdate(model);
            }
            return View(model);
        }
    }
}
