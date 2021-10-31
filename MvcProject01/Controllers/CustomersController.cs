using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject01.Models;
namespace MvcProject01.Controllers
{
    public class CustomersController : Controller
    {
       static  CustomerBO context = new CustomerBO();
        public IActionResult Index()
        {
            List<CustomerModel> customers = context.GetCustomers();
            //return View(customers);

            return View(context.GetCustomers());
        }
        public IActionResult Details(int id)
        {
            return View(context.GetCustomerById(id));
        }
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(CustomerModel c)
        {
            context.AddCustomer(c);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id) => View(context.GetCustomerById(id));
        [HttpPost]
        public IActionResult Edit(int id,CustomerModel c)
        {
            context.EditCustomer(c, c.Id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int id) {
            return View(context.GetCustomerById(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, CustomerModel c)
        {
            context.DeleteCustomer(id);
            return RedirectToAction("index");
        }
    }
}
