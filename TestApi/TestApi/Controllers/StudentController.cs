using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return new List<Student>
            {
                new Student() { Name = "Steve Ballmer", Number = 1},
                new Student() { Name = "Bill Gates", Number = 2}
            };
        }

        [FormatFilter]
        [Produces("application/json", "application/xml")]
        [HttpGet("{id}/{format?}")]
        public ActionResult<Student> Get(int id)
        {
            return new Student() {Name = $"Student{id}", Number = 1};
        }

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
    }
}
