using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoyalAirlines.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Flights()
        {
            return View();
        }

        public ActionResult Locations()
        {
            return View();
        }
    }
}