// [I]. HEAD
//  A] Libraries
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

using Microsoft.Extensions.Logging;

///
namespace ClerkTracker.Client.WebApi.Controllers
{
  /// 
  [ApiController]
    [Route("[controller]")]
    [EnableCors]
    public class ServiceController : ControllerBase
    {
        //  B] Properties
        private static readonly string[] Summaries = new[]
        {
            "PlanDay", "DayPlanned"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        //  C] 
        /// Load the logging on creation.
        public ServiceController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // [II]. BODY
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Web Service Connected!");
        }

        // [III]. FOOT
        
    }// /cla 'ServiceController'
}
