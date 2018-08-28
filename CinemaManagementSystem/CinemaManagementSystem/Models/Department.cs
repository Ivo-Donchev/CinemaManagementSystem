using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagementSystem.Models
{
    public class Department
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(32), Display(Name = "name")]
        public string Name { get; set; }

        public int CityForeignKey { get; set; }

        [ForeignKey("CityForeignKey")]
        public City City { get; set; }
    }
}