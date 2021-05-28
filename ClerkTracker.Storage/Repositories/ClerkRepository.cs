// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using ClerkTracker.Domain.Interfaces;
using ClerkTracker.Domain.Models.Employees;
using ClerkTracker.Storage;

///
namespace PizzaBox.Storage.Repositories
{
  ///
  public class ClerkRepository : IRepository<Clerk>
  {
    public List<Clerk> Clerk { get; set; } //<...>

    private readonly ClerkTrackerContext _context;


    // a parameterless construcor is required.
    public ClerkRepository() : base() { }
    public ClerkRepository(ClerkTrackerContext context) { _context = context; }

    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(Clerk clerk)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.Clerks.Add(clerk);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }
      //$"There was an issue with adding pizza customer {customer}";

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<Clerk> Select(Func<Clerk, bool> filter)
    {
      return _context.Clerks.Where(filter);
    }

    /// 3. Update
    public Clerk Update(Clerk clerk)
    {
      //  a) head


      //  b) body


      //  c)
      return clerk;
    }// /'Update'

    /// 4. Delete
    public bool Delete(Clerk clerk)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body


      //  c)
      didSucceed = true;
      return didSucceed;
    }

    // [III]. FOOT
    ///
    public override string ToString()
    {
      return "";//<!>
    }

    public List<Clerk> ToList() { return Clerk; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // EoF