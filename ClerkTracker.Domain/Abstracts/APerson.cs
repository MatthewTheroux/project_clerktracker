// [I]. HEAD
//  A] Libraries
using ClerkTracker.Domain.Models.Locations;

/// 
namespace ClerkTracker.Domain.Abstracts
{
    public class APerson : AnEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string FullName
        {
            get{return $"{FirstName} {LastName}";}
        }

        //public int Ssn {get;}

        public Address address {get; set;}
    }// /cla 'APerson'
}// /ns '..Abstracts'
// [EoF]