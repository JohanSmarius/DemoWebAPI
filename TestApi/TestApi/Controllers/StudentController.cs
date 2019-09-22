using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return new List<Student>
            {
                new Student() { Name = "Steve Ballmer", Number = 1},
                new Student() { Name = "Bill Gates", Number = 2}
            };
        }

        // GET api/values/5
        [FormatFilter]
        [Produces("application/json", "application/xml")]
        [HttpGet("{id}/{format?}")]
        public ActionResult<Student> Get(int id)
        {
            return new Student() {Name = "Steve Ballmer", Number = 1};
        }

        // POST api/values
        [HttpPost]
        [Consumes("application/xml")]
        public IActionResult PostXml([FromBody] Student student)
        {
            return Ok(student);
        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostJson([FromBody] Student student)
        {
            return Ok(student);
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
