using Microsoft.AspNetCore.Mvc;

namespace Finance_Management_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the Finance Management System!");
        }
    }
}
