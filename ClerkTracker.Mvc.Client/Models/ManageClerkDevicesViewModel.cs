// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

///
namespace ClerkTracker.Client.Mvc.Models
{
  public class ManageClerkDevicesViewModel : AViewModel
  {
    //  B] Properties
    public List<string> DevicesDiscovered {get; set;}
    public List<string> DevicesConnected{get; set;}
    
/*
    public Button addDevice;
    public Button removeDevice;
    public Button exit;
*/

  }// /cla 'ManageClerkDevicesViewModel'
}// /ns '..Mvc.Models
// [EoF]