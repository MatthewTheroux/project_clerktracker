using Microsoft.AspNetCore.Mvc;

namespace ClerkTracker.Client.WebApi.Controllers
{
  [Route("[controller]")]
  public class ServiceController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get() 
    {
      return Ok("'Works.");
    }
  }
}