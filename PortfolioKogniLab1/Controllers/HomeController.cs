using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace PortfolioKogniLab1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("CV")]
        public IActionResult CV()
        {
            return View();
        }

        [Route("Kontakt")]
        public IActionResult Kontakt()
        {
            return View();
        }

        [Route("Omnie")]
        public IActionResult Omnie()
        {
            return View();
        }

        [Route("Projekty")]
        public IActionResult Projekty()
        {
            return View();
        }
    }
}
