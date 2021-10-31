using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject01.Controllers
{
    public class PostBackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.msg = "Hello, Welcome!";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id)
        {
            ViewBag.msg = "Hi, Welcome back!";
            return View();
        }
        [HttpGet]
        public IActionResult Ex01()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex01(string b1)
        {
            ViewBag.msg = b1;
            return View();
        }

        [HttpGet]
        public IActionResult Ex02()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex02(string t1)
        {
            ViewBag.msg = "Mr."+ t1;
            return View();
        }
    }
}
