using RoyalAirlines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoyalAirlines.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext _context;
        public ContactController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var messages = _context.Contacts;
            if (User.IsInRole("Admin"))
            {
                return View("messages", messages);
            }
            else
            {
                return View();
            }
        }
            [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var messageInDB = _context.Contacts.SingleOrDefault(c => c.Id == id);
            _context.Contacts.Remove(messageInDB);
            _context.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
        public ActionResult Save(Contact contact)
        {
            if (contact.Id == 0)
            {
                _context.Contacts.Add(contact);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
    }
}