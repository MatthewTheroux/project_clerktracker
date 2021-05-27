// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

using ClerkTracker.Domain.Abstracts;
using ClerkTracker.Domain.Models.Employees;

///
namespace ClerkTracker.Domain.Models.Scheduling
{
  ///
  public class DailyClerkSchedule : ASchedule
  {
    /// 
    public List<Clerk> ClerksScheduledForToday {get; set;}

    /// Agree on the CSM who will route the clerks-- normally, the head CSM, if present.
    public Csm ClerkCaptain {get; set;}

  }// /cla 'DailyClerkSchedule'
}// /ns '..Scheduling'
// [EoF]