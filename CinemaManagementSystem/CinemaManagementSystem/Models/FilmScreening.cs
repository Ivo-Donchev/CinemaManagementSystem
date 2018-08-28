using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagementSystem.Models
{
    public class FilmScreening
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [ForeignKey("Department")]
        public Department Department { get; set; }

        [ForeignKey("Movie")]
        public Movie Movie { get; set; }
    }
}