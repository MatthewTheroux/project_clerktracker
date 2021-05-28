// [I]. HEAD
//  A] Libraries
using System;
using System.Text;

/// 
namespace ClerkTracker.Domain.Models.Locations
{
  /// 
  public class Address
  {
    //  B] Fields & Properties
    public string Name {get; private set;} 
    public StreetAddress StreetAddress {get; private set;} 
    public string City {get; private set;} 
    public string Province {get; private set;} // 'State'
    public string ProvinceCode {get; private set;} 
    public string PostalCode {get; private set;} // 'zip'
    public string Country {get; private set;} 
    public string CountryCode {get; private set;} 

    //  C] Constructors
    // [II]. BODY
    public Address()
    {
      //default = 300 Alamo Plaza, San Antonio, TX 78205
      Name = "The Alamo";
      StreetAddress = new StreetAddress();
      City = "San Antonio";
      Province = "Texas";
      ProvinceCode = "TX";
      PostalCode = "78205";
      Country = "United States";
      CountryCode = "USA";
    }

    // [III]. FOOT
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      return sb.ToString();
    }// /md 'ToString'
  }// /cla
}// /ns