using System.Data.Entity;

namespace CinemaManagementSystem.Models
{
    public class CinemaContext : DbContext
    {
        public CinemaContext() : base("CinemaManagementSystem")
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<FilmScreening> FilmScreenings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}