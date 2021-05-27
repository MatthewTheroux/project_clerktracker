using ClerkTracker.Domain.Abstracts;

namespace ClerkTracker.Domain.Models.Employees
{
  public class Csm : AnEmployee
  {
    public static Csm HeadCsm {get;} = new Csm
    {
      FirstName = "Margaret",
      LastName = "Kowaski"
    };

  }// /cla 'Csm'
}// /ns '..Models'
// [EoF]