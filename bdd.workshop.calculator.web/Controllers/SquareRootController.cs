using Microsoft.AspNetCore.Mvc;

namespace bdd.workshop.calculator.web.Controllers
{
    public class SquareRootController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Properties(Models.Number number)
        {
            ViewData["number"] = number.TheNumber;
            ViewData["result"] = Operator.SquareRoot(number.TheNumber);
            return View();
        }
    }
}
