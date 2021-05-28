// [I]. HEAD
//  A] Libraries
using System.Text;

namespace ClerkTracker.Domain.Models.Locations
{
  public class StreetAddress
  {
    //  B] Properties
    public int Number { get; private set; }
    public string Letters { get; private set; }
    public string StreetName { get; private set; }
    public string Direction { get; private set; }


    // [II]. BODY
    /// basic constructor
    public StreetAddress(int _number, string _name, string _direction = null)
    : this(_number, "", _name, _direction) { }

    /// detailed constructor
    public StreetAddress(int _number, string _letters, string _name, string _direction = null)
    {
      Number = _number;
      Letters = _letters;
      StreetName = _name;
      Direction = _direction;
    }

     /// 1-letter constructor
    public StreetAddress(int _number, char _letter, string _name, string _direction = null)
    : this(_number, _letter.ToString(), _name, _direction) { }

    /// "smart" constructor. filters 'index' into numbers and letters
    public StreetAddress(string _index, string _name, string _direction = null)
    {
      int _numb = 0;
      int.TryParse(_index, out _numb);
      Number = _numb;

      _index = _index.Replace(_numb.ToString(), "");
      Letters = _index;

      StreetName = _name;
      Direction = _direction;
    }// /smart cxtr

    /// default constructor = 300 Alamo Plaza
    public StreetAddress():this(300, "Alamo Plaza"){}


    // [III]. FOOT
    /// the string representation of a StreetAddress
    public override string ToString()
    {
      //  a) head
      StringBuilder sb = new StringBuilder();

      //  b) body
      sb.Append(Number);
      sb.Append(" " + Letters);
      sb.Append(" " + StreetName);
      sb.Append(" " + Direction);

      //  c) foot
      return sb.ToString();
    }// /fx 'ToString'

  }// /cla 'StreetAddress'
}// ns '..Models/."
 // [EoF]