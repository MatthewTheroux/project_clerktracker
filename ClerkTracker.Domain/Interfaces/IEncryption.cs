// [I]. HEAD
//  A] Libraries
using System.Linq;
using System.Text;

/// tools for other classes
namespace ClerkTracker.Domain.Interfaces
{
  /// Encode and Decode 
  public interface IEncryption<T> where T : class
  {
    public T Encrpyt(T item);
    public T Decrypt(T item);
  
  }// /ifc
}// /ns
//[EoF]