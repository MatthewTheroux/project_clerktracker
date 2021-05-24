// [I]. HEAD
//  A] Libraries
using ClerkTracker.Domain.Models;//.Locations;

/// 
namespace ClerkTracker.Domain.Abstracts
{
    public abstract class APerson : AnEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string FullName
        {
            get{return $"{FirstName} {LastName}";}
        }

        public int Ssn {get;} = 987654321;

        //public Address address {get; set;}

        // [II]. BODY
        public APerson()
        {
            EntityId = Ssn;
        }

        // [III]. FOOT
        public override string ToString()
        {
            return FullName;
        }
        
    }// /cla 'APerson'
}// /ns '..Abstracts'
// [EoF]