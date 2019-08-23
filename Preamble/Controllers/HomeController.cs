using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Preamble.Models;

namespace Preamble.Controllers
{
    public class HomeController : Controller
    {
    
    public IActionResult Index()
        {
            var preamble = "We the People of the United States in Order to" +
                " form a more perfect Union establish Justice " +
                "insure domestic Tranquility provide for the common " +
                "defense promote the general Welfare and secure the " +
                "Blessings of Liberty to ourselves and our Posterity " +
                "do ordain and establish this Constitution for the United " +
                "States of America.";
            

            var s = preamble.Split(' ');
            var tcount = 0;
            var ecount = 0;
            var tecount = 0;
            foreach (var c in s)
            {
               var l = c.ToLower();

                if (l.StartsWith("t"))
                {
                    tcount++;
                    ViewData["tcount"] = tcount;
                }
                if (l.EndsWith("e"))
                {
                    ecount++;
                    ViewData["ecount"] = ecount;
                }
                if (l.StartsWith("t") && l.EndsWith("e"))
                {
                    tecount++;
                    ViewData["tecount"] = tecount;
                }


            }
           
                

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
