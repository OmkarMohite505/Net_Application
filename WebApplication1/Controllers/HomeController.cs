using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("need_success")]
        public IActionResult SendSuccessMessage()
        {
            return Ok("Success message from Docker Image");
        }
    }
}
