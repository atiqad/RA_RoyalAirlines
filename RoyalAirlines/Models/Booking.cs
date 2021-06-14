using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoyalAirlines.Models
{
    public class Booking
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Flight Flight { get; set; }
        //public virtual ApplicationUser Users { get; set; }
        public DateTime DateBooked { get; set; }
    }
}