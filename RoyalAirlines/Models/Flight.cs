using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoyalAirlines.Models
{
    public class Flight
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Code { get; set; }
        [Display(Name = "Travel Date")]
        public DateTime Time { get; set; }
        [Display(Name = "From")]
        [Required]
        public string Origin { get; set; }
        [Display(Name = "To")]
        [Required]
        public string Destination { get; set; }
        [Display(Name = "Total Seats")]
        [Required]
        public int seatsEmpty { get; set; }
        [Display(Name = "Vacant Seats")]
        public byte seatsLeft { get; set; }
    }
}