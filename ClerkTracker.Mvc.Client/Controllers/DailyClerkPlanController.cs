// [I], HEAD
//  A] Libraries
using Microsoft.AspNetCore.Mvc;

/// 
namespace ClerkTracker.Client.Mvc.Controllers
{
  [Route("[controller]")]
  public class DailyClerkPlanController : Controller
  {
    public IActionResult DailyClerkPlan() { return View("DailyClerkPlan"); }

  }// /cla 'DailyClerkPlanController'
}// /ns '..Mvc.Controllers'
//[EoF]