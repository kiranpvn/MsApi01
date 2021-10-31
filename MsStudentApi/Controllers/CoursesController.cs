using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MsStudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CoursesController : ControllerBase
    {
        // GET: api/<CoursesController>
        CourseBO context = new CourseBO();
        [HttpGet]
        public IEnumerable<CourseModel> Get() => context.GetCourses();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public CourseModel Get(int id) => context.GetCourseById(id);

        // POST api/<CoursesController>
        [HttpPost]
        public void Post([FromBody] CourseModel c) => context.AddCourse(c);

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CourseModel c) => context.EditCourse(c, id);

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => context.DeleteCourse(id);
    }
}
