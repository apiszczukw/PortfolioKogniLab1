using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioKogniLab1.DAL;


namespace PortfolioKogniLab1.Controllers
{
    public class HomeController : Controller
    {

        ProjectsContext db;

        public HomeController(ProjectsContext db)
        {
            this.db = db;
        }

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
            var projekty = db.Projects.ToList();

            ViewBag.Projekty = projekty;

            return View();
        }
    }
}
