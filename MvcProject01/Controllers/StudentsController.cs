using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject01.Models;
namespace MvcProject01.Controllers
{
    public class StudentsController : Controller
    {
        StudentBO context = new StudentBO();
        public IActionResult Index()
        {
            ViewBag.students = context.GetAllStudents();
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.s = context.GetStudentById(id);
            return View();
        }
        public IActionResult AllStudents()
        {
            ViewBag.students = context.GetAllStudents();
            return View();
        }
        public IActionResult AngularStudents()
        {
            ViewBag.students = context.GetAngularStudents();
            return View();
        }
        public IActionResult ReactStudents()
        {
            ViewBag.students = context.GetReactStudents();
            return View();
        }

    }
}
