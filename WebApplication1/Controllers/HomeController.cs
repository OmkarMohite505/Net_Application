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
          [HttpGet("get_file")]
  public IActionResult GetFile()
  {
      try
      {
          string fullPath = Path.Combine("GitCommands.txt");
          string content = System.IO.File.ReadAllText(fullPath);
          return Ok(content);
      }
      catch (Exception ex)
      {

          return Ok(ex.Message);
      }
  }
    }
}
