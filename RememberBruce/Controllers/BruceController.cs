using Microsoft.AspNetCore.Mvc;
using RememberBruce.Models;

namespace RememberBruce.Controllers
{
    public class BruceController : Controller
    {
        private BruceContext db;
        public BruceController(BruceContext context)
        {
            db = context;
        }

        [HttpGet("/home")]
        public IActionResult Index()
        {
            return View("Dashboard");
        }

        [HttpGet("add")]
        public IActionResult NewTruck()
        {
            return View("AddTruck");
        }

        [HttpGet("edit")]
        public IActionResult Edit()
        {
            return View("EditTruck");
        }

        [HttpGet("about")]
        public IActionResult Summary()
        {
            return View("AboutBruce");
        }
    }
}