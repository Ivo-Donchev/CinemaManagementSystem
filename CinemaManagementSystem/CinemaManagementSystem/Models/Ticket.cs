using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagementSystem.Models
{
    public class Ticket
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, Display(Name = "price")]
        public decimal Price { get; set; }

        public int FilmScreeningForeignKey { get; set; }

        [ForeignKey("FilmScreeningForeignKey")]
        public FilmScreening FilmScreening { get; set; }

        public int UserForeignKey { get; set; }

        [ForeignKey("UserForeignKey")]
        public User User { get; set; }
    }
}