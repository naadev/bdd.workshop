using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bdd.workshop.calculator.web.Controllers
{
    public class NumberPropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Properties(Models.Number number)
        {
            ViewData["Number"] = number.TheNumber;
            switch (number.TheNumber)
            {
                case 0:
                    ViewData["IsNotPrimeNumber"] = string.Empty;
                    ViewData["IsPrimeNumber"] = string.Empty;
                    ViewData["IsUndefined"] = "X";
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                case 11:
                case 13:
                case 17:
                case 19:
                case 23:
                case 29:
                case 31:
                    ViewData["IsNotPrimeNumber"] = string.Empty;
                    ViewData["IsPrimeNumber"] = "X";
                    ViewData["IsUndefined"] = string.Empty;
                    break;
                default:
                    ViewData["IsNotPrimeNumber"] = "X";
                    ViewData["IsPrimeNumber"] = string.Empty;
                    ViewData["IsUndefined"] = string.Empty;
                    break;
            }
            return View();
        }
    }
}
