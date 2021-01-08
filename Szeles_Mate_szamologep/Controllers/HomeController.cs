using System;
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
            string firstNum = Request.Form["firstTypingRow"];
            string secondNum = Request.Form["secondTypingRow"];

            if (firstNum.Equals(""))
                firstNum = "0";

            if (secondNum.Equals(""))
                secondNum = "0";

            string[] firstNumParts = firstNum.Split(" ");

            string operation;
            try
            {
                operation = firstNumParts[1];
            } catch (IndexOutOfRangeException)
            {
                operation = "+";
            }
            

            double a = Convert.ToDouble(Regex.Replace(firstNumParts[0], "[^0-9,]", ""));
            double b = Convert.ToDouble(Regex.Replace(secondNum, "[^0-9,]", ""));
            double result = 0;

            if (operation == "+")
            {
                result = a + b;
            } else if(operation == "-")
            {
                result = a - b;
            } else if(operation == "×")
            {
                result = a * b;
            } else if(operation == "/")
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
