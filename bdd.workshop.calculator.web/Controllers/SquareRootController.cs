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
        public IActionResult SquareRoot(Models.SquareRoot squareRooter)
        {
            ViewData["number"] = squareRooter.Number.TheNumber;
            ViewData["result"] = Operator.SquareRoot(squareRooter.Number.TheNumber);
            return View();
        }
    }
}
