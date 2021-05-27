// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

using ClerkTracker.Domain.Interfaces;

/// blueprints for models
namespace ClerkTracker.Domain.Abstracts
{
  /// a blueprint for handling mobile devices
  public abstract class ADevice : AnEntity//, IEncryption<string>
  {
    //  B] Properties
    //   1. identification for this device 
    //      (also, for class construction)
    public string BrandName {get; protected set;}
    public string ModelName {get; protected set;}
    public string ModelNumber {get; protected set;}
    public string SerialNumber {get; protected set;}
    public int IpAddress {get; protected set;}

    public string Designation 
    {
      get
      {
        return $"{BrandName} {ModelName} {ModelNumber} #{SerialNumber}";
      }
    }


    //   2. Device Lists
    public List<ADevice> DiscoveredDevices {get; protected set;}
    public List<ADevice> ConnectedDevices {get; protected set;}

    //   3. Geolocation
    public string CurrentLocation 
    {
      get
      {
        //  a) head
        int x = 0, y = 0;

        //  b) body
        // (Gimmie Coordinates).  //<...> This is the hard part.
        //this.getGeoLocationCoordinates();

        //  c) foot
        return $"({x}, {y})";
      }
    }// /prop 'CurrentLocation'

    //  C] Constructors (of concrete children, of course).
    public ADevice(string brandName, string modelName, string modelNumber, string serialNumber)
    {
      BrandName = brandName;
      ModelName = modelName;
      ModelNumber = modelNumber;
      SerialNumber = serialNumber;
    }

    // [II]. BODY
    //  A] Head
    public List<ADevice> DiscoverDevices()
    {
      //  a) head
      List<ADevice> disccoveredDevices = new List<ADevice>();

      //  b) body


      //  c) foot
      return disccoveredDevices;
    }// /fx 'DiscoverDevices'

    /// 
    public bool ConnectDevice(ADevice newDevice)
    {
      //  a) head: Make sure the device CAN connect.
      if(!DiscoveredDevices.Contains(newDevice))
      {
        // Check again, just to be sure.
        DiscoverDevices();
        // 'Last chance.
        if(!DiscoveredDevices.Contains(newDevice))  return false;
      }

      //  b) body: Connect the device, if possible
      // <...>

      //  c) foot
      ConnectedDevices.Add(newDevice);
      return true;
    }// /md 'ConnectDevice'


    //  B] Body
    //   0.
    /// 
    public string LocateDevice(ADevice device)
    {
      //  a) head
      string geolocationCoordinates = ""; //<...>
      string responseMessage = ""; //<...>
       string DEVICE_NOT_LISTED_CONNECTED = $"{device.ToString()} has not been connected."; 
       string CANNOT_LOCATE_DEVICE =  $"Cannot locate {device.ToString()}. \nIt appears to no longer be connected.";

      //  b) body
      //   i. head
      /// Check if the device is still listed among the connected devices.
      if(!ConnectedDevices.Contains(device))
      {
        return (responseMessage = DEVICE_NOT_LISTED_CONNECTED);
      }

      //   ii. body
      /// Check if the device currently remains connected.
      try 
      {
        geolocationCoordinates = device.CurrentLocation; 
        responseMessage = geolocationCoordinates.ToString(); // <- success, 'got it.
      }
      catch(Exception noResponseException)
      {
        string exceptionMessage = noResponseException.ToString();
        return responseMessage = CANNOT_LOCATE_DEVICE;
      }

      //  c) foot
      return responseMessage;
    }// /fx 'Locate..'

    //  B] Body
      ///   1. 'Scrambles a message.
    public string Encrypt(string message, int code = 17)
    {
      //  a) head
      StringBuilder encryptedMessage = new StringBuilder();

      //  b) body
      foreach(char letter in message)
      {
        encryptedMessage.Append( (letter.GetTypeCode() + code ).ToString()[0] );
      }
      
      //  c) foot
      return encryptedMessage.ToString();
    }// /fx 'Encrypt..'

    ///   2. a) Send a message to another device.
    public bool SendMessage(ADevice device, string message="Hello.")
    {
      //  a) head
      message = Encrypt(message);

      //  b) body
      //<...>

      //  c) foot
      return true;
    }// /fx 'Send..'

    ///     b) Receive a message from another device.
    public string ReceiveMessage(ADevice sourceDevice, string receivedMessage)
    {
      //  a) head
      string responseMessage = "";

      //  b) body:  Check if the device is "friended" via connection status.
      if(!ConnectedDevices.Contains(sourceDevice))
      {
        //   i. Reject messages from non-friended devices.
        responseMessage =  $"A message was attempted from unauthorized device {sourceDevice.ToString()}.";
      }
      else
      {
      //    ii. Decode a message from a trusted device.
        receivedMessage = Decrypt(receivedMessage);
        responseMessage = receivedMessage;
        DisplayMessage(receivedMessage);
      }
      
      //  c) foot
      return responseMessage;
    }// /fx 'ReceiveMessage'

    ///  txmt: c) Display a message received from another trusted device.
    public void DisplayMessage(string message)
    {
      System.Console.WriteLine(message);
    }


    ///   3. 'Unscambles a message.
    public string Decrypt(string encryptedMessage, int code = 17)
    {
      //  a) head
      StringBuilder decryptedMessage = new StringBuilder();

      //  b) body
      foreach(char letter in encryptedMessage)
      {
        decryptedMessage.Append( (letter.GetTypeCode() - code ).ToString()[0] );
      }      
      
      //  c) foot
      return decryptedMessage.ToString();
    }// /fx 'Decrypt..'


    //  C] Foot
    ///
    public bool DisconnectDevice(ADevice device)
    {
      //  a) head
      if(ConnectedDevices.Contains(device))
      {
        ConnectedDevices.Remove(device);
      }

      //  c) foot
      return true;
    }

    // [III]. FOOT
    public override string ToString() 
    {
      return Designation;
    } 

  }// /cla 'ADevice'
}// /ns '..Abstracts'
// [EoF]