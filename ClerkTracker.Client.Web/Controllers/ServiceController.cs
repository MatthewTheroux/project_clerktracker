// [I]. HEAD
//  A] Libraries
using Microsoft.AspNetCore.Mvc;

/// 
namespace ClerkTracker.Client.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ServiceController : ControllerBase
  {

    // [II]. BODY
    [HttpGet]
    public IActionResult Get() 
    {

      return Ok("'Works.");
    }// /'Get'
    
    [HttpGet]
    public IActionResult Get2() 
    {
      
      return Ok("'Works.");
    }// /'Get'

    // [III]. FOOT
  }// /cla 'ServiceController'
}// /ns '..WebApi.Controllers'
// [EoF]