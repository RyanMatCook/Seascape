using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seascape.Models;

namespace Seascape.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to the Seascape website! Here you will find Southcoast accommodation venues to rent.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Who we are and how we can help you.";

            return View();
        }

        public IActionResult Activities()
        {
            ViewData["Message"] = "Activities available in the Southcoast area.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact us to enquire about availability on accommodation.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
