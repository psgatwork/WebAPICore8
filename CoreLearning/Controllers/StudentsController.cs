using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "ගයාන්", "ජානබ", "ව්කල්ස්", "ලෙක්ස්" };  
            return Ok(studentNames);
        }
    }
}
