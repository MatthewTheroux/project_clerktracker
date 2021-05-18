// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

namespace ClerkTracker.Domain.Abstracts
{
  public class AWorkSchedule : ASchedule
  {
    List<AnEmployee> Employees {get; set;} 
    List<DateTime> TimesIn {get; set;}
    List<DateTime> Break1Time {get; set;}
    List<DateTime> Break2Time {get; set;}
    List<DateTime> Break3Time {get; set;}
    List<DateTime> TimesOut {get; set;}
    
  }// /cla 'AWrokSchedule'
}// /ns '..Abstracts'
// [EoF]