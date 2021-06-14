using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoyalAirlines.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RoyalAirlines.Controllers
{
    public class BookingController : Controller
    {
        private ApplicationDbContext _context;
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public BookingController()
        {
            this.ApplicationDbContext = new ApplicationDbContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.ApplicationDbContext));
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var bookings = _context.Bookings;
            return View(bookings);
        }
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Save(int id)
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            var flight = _context.Flights.Single(f => f.Id == id);
            /**
            if (flight.seatsLeft == 0) {
                return Content("Fully Booked!");
            }
            else
            {
    **/
                flight.seatsLeft--;
                var booking = new Booking
                {
                    Flight = flight,
                    //Users = user,
                    DateBooked = DateTime.Now
                };
            //}
            _context.SaveChanges();
            return RedirectToAction("Index", "Booking");
        }
    }
}