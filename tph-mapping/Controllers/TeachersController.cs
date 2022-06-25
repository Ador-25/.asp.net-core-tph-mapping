using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tph_mapping.Contexts;
using tph_mapping.Models;

namespace tph_mapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        ApplicationDbContext _applicationDbContext;
        public TeachersController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }

        [Route("add-teacher")]
        [HttpPost]
        public IActionResult AddTeacher([FromBody] TeacherAccount teacherAccount)
        {
            return Ok("Adding Teacher");
        }
    }

}
