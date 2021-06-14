using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoyalAirlines.Models
{
    public class Contact
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Write Correct Format")]
        [RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,}$")]
        public string Email { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }

    }
}