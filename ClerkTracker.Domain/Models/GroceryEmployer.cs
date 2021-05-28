using ClerkTracker.Domain.Abstracts;
namespace ClerkTracker.Domain.Models
{
  public class GroceryEmployer : AnEmployer
  {

    public GroceryEmployer(string name):base(name){}
    public GroceryEmployer(int id):base(id){}
    public GroceryEmployer(string name, int id):base(name, id){}

    public GroceryEmployer(){}

  }// /cla 'GroceryEmployer'
}// /ns '..Models'
// [EoF]