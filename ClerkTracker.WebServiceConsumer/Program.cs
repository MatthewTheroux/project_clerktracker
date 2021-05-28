// [I]. HEAD
//  A] Libraries
using System;

/// consumes the web service
namespace ClerkTracker.Mvc.WebServiceConsumer
{
    class Program
    {
        //  B] Constants, Fields, and Properties
        private const string appUrl = @"http://localhost:5555";


        // [II]. BODY
        static void Main(string[] args)
        {
            //  a) head
            string url = appUrl;
            
            //  b) body
            HttpClient client = new HttpClient();
            HttpRequest request = client.GetAsync(url);
            //HttpResponse response = client.Request("get", url);
            HttpResponse response = request.HttpContext;
            
            //  c) foot
            XmlSerializer xmlSerializer;
            xmlSerializer.Deserialize(response);
            response.Then(HandleGoodResponse, HandleBadResponse);
        }// /'Main'


        // [III]. FOOT
        public static void  HandleGoodResponse() 
        {
            Console.Log("The Web Service is Connected.");
        }

        public static void HandleBadResponse() 
        {
            Console.Error("There was an issue with Connecting to the Web Service.");
        }

    }// /'Program'
}// /ns '..Consumer'
// [EoF]