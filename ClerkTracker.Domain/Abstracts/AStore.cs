using System.Collections.Generic;

using ClerkTracker.Domain.Models;
using ClerkTracker.Domain.Models.Locations;

namespace ClerkTracker.Domain.Abstracts
{
  public abstract class AStore : AnEntity
  {
    public string Name {get;  set;} 

    public AnEmployer Employer {get; set;}

    public int StoreNumber {get;  set;}

    public Address Location{get; protected set;}

    public List<AnEmployee> Employees {get; set;}


    // [II]. BODY
    public AStore(string name)
    {
      Name = name;
    }

    public AStore(int storeNumber)
    {
      EntityId = StoreNumber = storeNumber;
    }

    public AStore(string chain, int storeNumber)
    {
      Name = chain;
      EntityId = StoreNumber = storeNumber;
    }



    // [III]. FOOT
    public override string ToString()
    {
      return $"{Name} #{StoreNumber}";
    }

  }// /cla 'AStore'
}// /ns '..Abstracts'
// [EoF]