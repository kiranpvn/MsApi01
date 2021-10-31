using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject01.Models;
namespace MvcProject01.Controllers
{
    public class EmployeesController : Controller
    {
        IEnumerable<IEmployeeRepository> _repositories = null;
        static IEmployeeRepository repository = null;
        public EmployeesController(IEnumerable<IEmployeeRepository> repositories)
        {
            _repositories = repositories;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string b1)
        {

            if (b1 == "inmemory")
                repository = _repositories.SingleOrDefault(x => x.SourceDB() == "inmemory");
            else if (b1 == "sqlserver")
                repository = _repositories.SingleOrDefault(x => x.SourceDB() == "sqlserver");
            return RedirectToAction("EmployeeList");
            //ViewBag.msg = repository.SourceDB();
            //return View();
        }
        public IActionResult EmployeeList()
        {
            ViewBag.source = repository.SourceDB();
            List<EmpModel> employees = repository.GetAllEmployees();
            return View(employees);
        }
    }
}
