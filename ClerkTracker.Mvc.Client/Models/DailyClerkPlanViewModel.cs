// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

/// 'Contains data models for web views.
namespace ClerkTracker.Client.Mvc.Models
{
  public class DailyClerkPlanViewModel : AViewModel
  {
    //  B] Properties
    public List<string> ClerksScheduledToday {get;  set;} // DB fetch

    public Dictionary<string, string> TimesForCartsClerks {get; set;}
    public Dictionary<string, string> TimesForRestroomsClerks {get; set;}
    public Dictionary<string, string> TimesForSweepsClerks {get; set;}


  }// /cla
}// /ns '..Mvc.Models
// [EoF]