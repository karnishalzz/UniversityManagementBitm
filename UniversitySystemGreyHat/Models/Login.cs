using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversitySystemGreyHat.Models
{
    public class Login
    {
        public int LoginId { get; set; }

        [Required(ErrorMessage = "Please provide UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please provide Password")]
        public string Password { get; set; }
    }
}