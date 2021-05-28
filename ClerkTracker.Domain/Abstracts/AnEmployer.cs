// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

using ClerkTracker.Domain.Models.Locations;

/// blueprints for solid ideas
namespace ClerkTracker.Domain.Abstracts
{
  /// someone who hiers workers
  public abstract class AnEmployer : AnEntity
  {
    //  B] Properties

     public string Name {get; protected set;}

    /// the employer's tax id
    public int EmployerId {get; protected set;}

    public List<AStore> Stores {get; protected set;}
    public Address BaseLocation {get; protected set;}

    // [II]. BODY
    public AnEmployer(string name)
    {
      Name = name;
    }

    public AnEmployer(int employerId)
    {
      EntityId = EmployerId = employerId;
    }

    public AnEmployer(string name, int employerId)
    {
      Name = name;
      EntityId = EmployerId = employerId;
    }

  }// /cla 'AnEmployer'
}// /ns '..Abstracts'
// [EoF]