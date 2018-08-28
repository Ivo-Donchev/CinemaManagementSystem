using System.Collections.Generic;
using System.Data.Entity;

namespace CinemaManagementSystem.Models
{
    public class CinemaInitializer : DropCreateDatabaseIfModelChanges<CinemaContext>
    {
        protected override void Seed(CinemaContext context)
        {
            GetDistricts().ForEach(p => context.Districts.Add(p));
            GetCities().ForEach(c => context.Cities.Add(c));
        }

        private static List<District> GetDistricts()
        {
            return new List<District> {
                new District
                {
                    Id = 1,
                    Name = "North"
                },
                new District
                {
                    Id = 1,
                    Name = "North"
                },
            };
        }
        private static List<City> GetCities()
        {
            return new List<City> {
                new City
                {
                    Id = 1,
                    Name = "Stara Zagora",
                    District = 1
                },
            };
        }
    }
}