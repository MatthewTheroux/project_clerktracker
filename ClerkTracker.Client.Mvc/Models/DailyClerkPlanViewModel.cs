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

    /*
    public Button SpillAlert1;
    public Button SpillAlert2;

    public Button BottleBinAlert;
    public Button GarbageRunAlert;

    public Button ManageClerkDevices;
    */

  }// /cla
}// /ns '..Mvc.Models
// [EoF]