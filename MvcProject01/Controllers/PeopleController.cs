using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject01.Models;
namespace MvcProject01.Controllers
{
    public class PeopleController : Controller
    {
        static PersonBO context = new PersonBO();
        public IActionResult Index()        //To access all records
        {
            List<PersonModel> people = context.GetPeople();
            ViewBag.people = people;
            return View();
        }
        public IActionResult Details(int id)
        {
            PersonModel p = context.GetPeople().Single(x => x.Id == id);
            ViewBag.p = p;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string pname, string gender, int age)
        {
            try
            {
                PersonModel p = new PersonModel();
                p.Id = id; p.PName = pname; p.Gender = gender; p.Age = age;
                context.AddPerson(p);
                return RedirectToAction("index");
            }
            catch ( Exception ex)
            {
                ViewBag.msg = "error " + ex.Message;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            PersonModel p = context.GetPeople().Single(x => x.Id == id);
            ViewBag.p = p;
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id, string pname, string gender, int age)
        {
            PersonModel p = new PersonModel()
            {
                Id = id,
                PName=pname,
                Gender=gender,
                Age=age
            };
            context.EditPerson(p, id);

            return RedirectToAction("index");
       
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            PersonModel p = context.GetPeople().Single(x => x.Id == id);
            ViewBag.p = p;
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id,string pname, string gender, int age)
        {
            PersonModel p = context.GetPeople().Single(x => x.Id == id);
            context.DeletePerson(p);
            return RedirectToAction("index");
        }
    }
}
