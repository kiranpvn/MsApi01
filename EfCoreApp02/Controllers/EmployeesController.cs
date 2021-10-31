using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreApp02.Models;
namespace EfCoreApp02.Controllers
{
    public class EmployeesController : Controller
    {
        EmpDBContext context = new EmpDBContext();
        public IActionResult Index() => View(context.TblEmployees.ToList());
        public IActionResult Details(int id) => View(context.TblEmployees.Single(x => x.Id == id));
        
        
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(TblEmployee e)
        {
            context.TblEmployees.Add(e);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id) => View(context.TblEmployees.Single(x=>x.Id==id));
        [HttpPost]
        public IActionResult Edit(TblEmployee e)
        {           
            context.TblEmployees.Update(e);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id) => View(context.TblEmployees.Single(x => x.Id == id));
        [HttpPost]
        public IActionResult Delete(TblEmployee e)
        {
            context.TblEmployees.Remove(e);
            context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
