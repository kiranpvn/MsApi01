using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MsApi01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        static StudentBO context = new StudentBO();
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<StudentModel> Get() => context.GetAllStudents();

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public StudentModel Get(int id)  => context.GetAllStudents().Single(x => x.Id == id);

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] StudentModel s) => context.AddStudent(s);

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentModel s) => context.EditStudents(s, id);

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => context.DeleteStudent(id);
    }
}
