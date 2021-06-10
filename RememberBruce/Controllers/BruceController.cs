using Microsoft.AspNetCore.Http;
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

        [HttpGet("about")]
        public IActionResult Summary()
        {
            return View("AboutBruce");
        }

        [HttpGet("truck/new")]
        public IActionResult NewTruck()
        {
            int? loggedInID = HttpContext.Session.GetInt32("userId");
            if (loggedInID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("AddTruck");
        }

        [HttpPost("truck/add")]
        //Currently as it is, the database is not receiving the form data once submitted. 
        public IActionResult Create(Truck newTruck)
        {
            int? loggedInID = HttpContext.Session.GetInt32("userId");
            if (loggedInID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                newTruck.UserId = (int)loggedInID;
                db.Add(newTruck);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = newTruck.TruckId });
            }
            else
            {
                if (newTruck.Location == null)
                {
                    ModelState.AddModelError("Location", "The Location field is required.");
                }
                return View("AddTruck", newTruck);
            }
        }

        [HttpGet("location")]
        public IActionResult Detail()
        {
            return View("Detail");
        }



        [HttpGet("edit")]
        public IActionResult Edit()
        {
            return View("EditTruck");
        }

    }
}
