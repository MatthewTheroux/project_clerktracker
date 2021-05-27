

namespace ClerkTracker.Domain.Abstracts
{
  public abstract class AnEmployee : APerson
  {
    //  B] Properties
    public int EmployeeId {get; protected set;}

    public string Title {get; protected set;} 

    public string Department {get; protected set;}


    public AStore Store {get; protected set;}

    // [III]. FOOT
    public override string ToString()
    {
      return $"{base.ToString()} {Title}";
    } 
    
  }// /cla 'AnEmployee'
}// /ns '..Abstracts'
// EoF