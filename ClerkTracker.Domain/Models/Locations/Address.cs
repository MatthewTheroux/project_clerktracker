// [I]. HEAD
//  A] Libraries
using System;
using System.Text;

/// 
namespace PizzaBox.Domain.Models.Locations
{
  public class Address
  {
    //  B] Fields & Properties
    private string _name;
    // private int _streetNumber;
    // private string _streetNumberCharacters;
    // private string _streetName;
    private string _city;
    private string _province;
    private string _provinceCode;
    private string _postalCode;
    private string _country;
    private string _countryCode;

    //  C] Constructors
    // Focus on this, later.
    public Address()
    {
      //default: 300 Alamo Plaza, San Antonio, TX 78205
      _name = "The Alamo";
      // _streetNumber = 300;
      // _streetName = "Alamo Plaza";
      _city = "San Antonio";
      _province = "Texas";
      _provinceCode = "TX";
      _postalCode = "78205";
      _country = "United States";
      _countryCode = "USA";
    }

    // [II]. BODY
    // [III]. FOOT
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      return sb.ToString();
    }// /md 'ToString'
  }// /cla
}// /ns