using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CinemaManagementSystem.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(32), Display(Name = "full name")]
        public string FullName { get; set; }

        [Required, Display(Name = "full name")]
        public int Age { get; set; }
    }
}