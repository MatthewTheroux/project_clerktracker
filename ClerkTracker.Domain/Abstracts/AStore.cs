using ClerkTracker.Domain.Models.Locations;

namespace ClerkTracker.Domain.Abstracts
{
  public class AStore : AnEntity
  {
    public Employer Chain {get; protected set;} 

    public int StoreNumber {get; protected set;}

    public Address Location{get; protected set;}


    // [III]. FOOT
    public override string ToString()
    {
      return $"{Chain} #{StoreNumber}";
    }

  }// /cla 'AStore'
}// /ns '..Abstracts'
// [EoF]