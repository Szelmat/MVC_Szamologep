﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Szeles_Mate_szamologep.Models;

namespace Szeles_Mate_szamologep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        String[] ops = { "+", "-", "*", "×", "/" };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Equals()
        {
            // Beírt adatok lekérése
            string firstNum = Request.Form["firstTypingRow"];
            string secondNum = Request.Form["secondTypingRow"];

            // Ha valamelyik számot nem adtuk meg, akkor az 0
            if (firstNum.Equals(""))
                firstNum = "0";

            if (secondNum.Equals(""))
                secondNum = "0";

            // A műveleti jel és a szám elválasztása a space alapján
            string[] firstNumParts = firstNum.Split(" ");
            string operation = "";
            if (firstNumParts.Length < 2)
            {
                foreach(string op in ops) {
                    // Nem választja el space a műveleti jelet
                    if (firstNum.IndexOf(op) != -1)
                    {
                        operation = op;
                    }

                    // Nem adtunk meg műveletet
                    if(operation == "")
                    {
                        operation = "+";
                    }
                }
            } 
            else
            {
                try
                {
                    operation = firstNumParts[1];
                }
                catch (IndexOutOfRangeException)
                {
                    operation = "+";
                }
            }

            // Csak a számjegyeket és a tizedesvesszőket fogadjuk el
            double a = Convert.ToDouble(Regex.Replace(firstNumParts[0], "[^0-9,]", ""));
            double b = Convert.ToDouble(Regex.Replace(secondNum, "[^0-9,]", ""));
            
            double result = 0;

            // A művelet elvégzése műveleti jel alapján
            if (operation == "+")
            {
                result = a + b;
            } 
            else if(operation == "-")
            {
                result = a - b;
            } 
            else if(operation == "×" || operation == "*")
            {
                result = a * b;
            } 
            else if(operation == "/")
            {
                result = a / b;
            }


            ViewData["Result"] = result;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
