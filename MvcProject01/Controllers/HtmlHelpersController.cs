using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject01.Controllers
{
    public class HtmlHelpersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.msg = "Hello!";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string b1)
        {
            ViewBag.msg = "Hi, Welcome back ";
            return View();
        }
        [HttpGet]
        public IActionResult Ex01()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Ex01(string t1,string b1)
        {
            switch (b1)
            {
                case "length":
                    ViewBag.msg = $"Length of {t1} is {t1.Length}";
                    break;
                case "upper":
                    ViewBag.msg = t1.ToUpper();
                    break;
                case "lower":
                    ViewBag.msg = t1.ToLower();
                    break;
                case "fname":
                    ViewBag.msg = t1.Substring(0, t1.IndexOf(" "));
                    break;
                case "lname":
                    ViewBag.msg = t1.Substring(t1.LastIndexOf(" ")+1);
                    break;
            }
            
            return View();
        }
        [HttpGet]
        public IActionResult Ex02()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex02(int a,int b,string b1)
        {
            int c = 0;
            switch (b1)
            {
                case "add":
                    c = a + b;
                    break;
                case "sub":
                    c = a - b;
                    break;
                case "mult":
                    c = a * b;
                    break;
                case "div":
                    c = a / b;
                    break;
            }
            ViewBag.msg = $"{b1} of {a} and {b} is {c}";
            return View();
        }

        [HttpGet]
        public IActionResult Ex03()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex03(string t1,string gender)
        {
            ViewBag.msg = "Hello " + gender + " " + t1;
            return View();
        }
    }
}














