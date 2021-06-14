using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoyalAirlines.Models;
using RoyalAirlines.ViewModels;

namespace RoyalAirlines.Controllers
{
    public class FlightsController : Controller
    {
        private ApplicationDbContext _context;
        public FlightsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var flghts = _context.Flights;
            if (User.IsInRole("Admin"))
            {
                return View(flghts);
            }
            else
            {
                return View("userList", flghts);
            }
        }
        public ActionResult Search(Flight flight)
        {
            DateTime fDate = flight.Time.Date;
            var flghts = _context.Flights.Where(f => f.Origin == flight.Origin && f.Destination == flight.Destination && DbFunctions.TruncateTime(f.Time) == DbFunctions.TruncateTime(fDate)).ToList();
                var viewModel = new SearchFlightViewModel
                {
                    Flights = flghts
                };
                return View(viewModel);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Save(Flight flight)
        {
            if (flight.Id == 0)
            {
                _context.Flights.Add(flight);
            }
            else
            {
                var flightInDb = _context.Flights.Single(f => f.Id == flight.Id);
                flightInDb.Code = flight.Code;
                flightInDb.Time = flight.Time;
                flightInDb.Origin = flight.Origin;
                flightInDb.Destination = flight.Destination;
                flightInDb.seatsEmpty = flight.seatsEmpty;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Flights");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var flightInDB = _context.Flights.SingleOrDefault(f => f.Id == id);
            _context.Flights.Remove(flightInDB);
            _context.SaveChanges();
            return RedirectToAction("Index", "Flights");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var movie = _context.Flights.SingleOrDefault(f => f.Id == id);
            
            return View("New", movie);
        }
    }
}