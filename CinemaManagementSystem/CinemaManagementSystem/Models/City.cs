using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagementSystem.Models
{
    public class City
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(32), Display(Name = "name")]
        public string Name { get; set; }

        public int DistrictForeignKey { get; set; }

        [ForeignKey("DistrictForeignKey")]
        public District District { get; set; }
    }
}