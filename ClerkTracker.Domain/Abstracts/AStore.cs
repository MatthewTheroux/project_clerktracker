using ClerkTracker.Domain.Models;
//using ClerkTracker.Domain.Models.Locations;

namespace ClerkTracker.Domain.Abstracts
{
  public abstract class AStore : AnEntity
  {
    public AnEmployer Chain {get; protected set;} 

    public int StoreNumber {get; protected set;}

    //public Address Location{get; protected set;}


    // [III]. FOOT
    public override string ToString()
    {
      return $"{Chain} #{StoreNumber}";
    }

  }// /cla 'AStore'
}// /ns '..Abstracts'
// [EoF]