using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CinemaManagementSystem.Models
{
    public class CinemaManagementSystemInitializer : DropCreateDatabaseIfModelChanges<CinemaContext>
    {
        protected override void Seed(CinemaContext context)
        {
            var districts = GetDistricts();
            districts.ForEach(p => context.Districts.Add(p));
            GetCities(districts).ForEach(c => context.Cities.Add(c));
        }

        private static List<District> GetDistricts()
        {
            var districts = new List<District> {
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
            return districts;
        }
        private static List<City> GetCities(List<District> districts)
        {
            var cities = new List<City> {
                new City
                {
                    Id = 1,
                    Name = "Stara Zagora",
                    District = districts[0]
                },
            };
            return cities;
        }
    }
}
