using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetStudents()
        {
            string[] students = { "Henry", "Eric", "Alex" };
            if (students.Any())
                return NotFound();
            return Ok(students);

        }

        /*[HttpPost]
        public ActionResult CreateStudents()
        {
            string[] students = { "Henry", "Eric", "Alex" };
            
        }*/

        [HttpDelete]
        public ActionResult DeleteStudents()
        {
            bool badThingshappned = false;
            if (badThingshappned)
                return BadRequest();
            return NoContent();
        }
    }
}
