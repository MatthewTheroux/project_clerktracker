﻿// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ClerkTracker.Client.AddClerkDevice.Models;

///
namespace ClerkTracker.Client.AddClerkDevice.Controllers
{
    public class HomeController : ControllerBase
    {
       //  B] Properties
        

       // [II]. BODY
        public IActionResult Index(){return View();}

        public IActionResult Privacy(){return View(); }


        // [III]. FOOT
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }// /cla
}// /ns
