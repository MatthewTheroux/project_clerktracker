using System;
using System.Web;

using Microsoft.AspNetCore;

namespace ClerkTracker.Web.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"http://localhost:42798";
            HttpClient client = new HttpClient();
            HttpResponse response = client.Request("get", url);
            XmlSerializer xmlSerializer = new XmlSerializer();

            response.Then(HandleGoodResponse, HandleBadResponse);

            public void HandleGoodResponse { }
            public void HandleBadResponse { }
        }
    }
}
