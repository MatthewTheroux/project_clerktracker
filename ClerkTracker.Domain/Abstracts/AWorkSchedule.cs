// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Text;

///
namespace ClerkTracker.Domain.Abstracts
{
  ///
  public class AWorkSchedule : ASchedule
  {
    //  B] Properties
    List<AnEmployee> Employees {get; set;} 
    List<DateTime> TimesIn {get; set;}
    List<DateTime> Break1Times {get; set;}
    List<DateTime> Break2Times {get; set;}
    List<DateTime> Break3Times {get; set;}
    List<DateTime> TimesOut {get; set;}
    

    // [III]. FOOT
    public override string ToString()
    {
      //  a) head
      StringBuilder table = "";
      int index = 0;
      
      //  b) body
      foreach(AnEmployee employee in Employees)
      {
        table.Append($"{employee.ToString()} | "); 
        table.Append($"{TimesIn[index].ToString()} | ");
        table.Append($"{Break1Times[index].ToString()} |"); 
        table.Append($"{Break2Times[index].ToString()} |"); 
        table.Append($"{Break3Times[index].ToString()} |"); 
        table.Append($"{TimesOut[index].ToString()}");
        table.AppendLine();
        table.AppendLine("-----------------------------------------------");
      }// next employee

      //  c) foot
      return table.ToString();

    }// /fx 'ToString'

  }// /cla 'AWrokSchedule'
}// /ns '..Abstracts'
// [EoF]