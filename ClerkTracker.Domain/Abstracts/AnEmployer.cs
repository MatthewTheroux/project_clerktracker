using ClerkTracker.Domain.Models;//.Locations;

namespace ClerkTracker.Domain.Abstracts
{
  public abstract class AnEmployer : AnEntity
  {
     public string Name {get; protected set;}

    public int EmployerId {get; protected set;}

    //public Address BaseLocation {get; protected set;}

  }// /cla 'AnEmployer'
}// /ns '..Abstracts'
// [EoF]