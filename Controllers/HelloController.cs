using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers  // Make sure this matches the namespace of your project
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET api/hello
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from the Web API!");
        }
    }
}
