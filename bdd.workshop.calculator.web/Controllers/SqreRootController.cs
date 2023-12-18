using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace bdd.workshop.calculator.web.Controllers
{
    public class SqreRootController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult SqreResult(Models.Number number)
        {
            ViewData["Number"] = number.TheNumber;
            ViewData["Result"] = Operator.SquareRoot(number.TheNumber);
            return View();
        }
    }
}
