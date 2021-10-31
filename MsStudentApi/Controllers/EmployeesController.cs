using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsStudentApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MsStudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmpDBContext context = new EmpDBContext();
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<TblEmployee> Get()
        {
            return context.TblEmployees.ToList();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public TblEmployee Get(int id)
        {
            return context.TblEmployees.Single(x => x.Id == id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
