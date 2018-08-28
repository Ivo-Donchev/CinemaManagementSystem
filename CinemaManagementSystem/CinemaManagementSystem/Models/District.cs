using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CinemaManagementSystem.Models
{
    public class District
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(32), Display(Name = "name")]
        public string Name { get; set; }
    }
}