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
    }
}
