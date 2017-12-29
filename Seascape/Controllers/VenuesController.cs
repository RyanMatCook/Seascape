using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Seascape.Controllers
{
    public class VenuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Calendar Snippet:
        // https://bootsnipp.com/snippets/featured/calendar-design
        public IActionResult Availability(int venueId)
        {

            return View();
        }
    }
}