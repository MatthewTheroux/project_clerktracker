// [I], HEAD
//  A] Libraries
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using ClerkTracker.Client.Mvc.Models;

/// 
namespace ClerkTracker.Client.Mvc.Controllers
{
  [Route("[controller]")]
  public class DailyClerkPlanController : Controller
  {
    public IActionResult ManageClerkDevices() { return View(); }

    public IActionResult MessageClerk() { return View(); }

  }// /cla
}// /ns '..Mvc.Controllers'
//[EoF]