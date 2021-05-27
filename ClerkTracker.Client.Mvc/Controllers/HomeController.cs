using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using ClerkTracker.Client.Mvc.Models;

/// 
namespace ClerkTracker.Client.Mvc.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }// cla
}// /ns
