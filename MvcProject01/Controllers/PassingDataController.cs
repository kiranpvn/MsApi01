using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject01.Models;
namespace MvcProject01.Controllers
{
    public class PassingDataController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["name"] = "Kiran Kumar";
            //ViewData["city"] = "Hyderabad";

            ViewBag.name = "Kiran Kumar";
            ViewBag.city = "Hyderabad";
            return View();
        }
        public IActionResult Ex01()
        {
            ViewBag.girls = new string[] { "Rani", "Vani", "Devi" } ;
            ViewBag.boys = new List<string> { "Raj","Ram","dev","Gano"};
            return View();
        }
        public IActionResult Ex02()
        {
            PersonBO context = new PersonBO();
            List<PersonModel> people = context.GetPeople();
            ViewBag.people = people; //To carry data to the view
            return View();
        }
    }
}
