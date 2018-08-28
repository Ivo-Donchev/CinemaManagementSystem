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

        public int DepartmentForeignKey { get; set; }

        [ForeignKey("DepartmentForeignKey")]
        public Department Department { get; set; }

        public int MovieForeignKey { get; set; }

        [ForeignKey("MovieForeignKey")]
        public Movie Movie { get; set; }
    }
}