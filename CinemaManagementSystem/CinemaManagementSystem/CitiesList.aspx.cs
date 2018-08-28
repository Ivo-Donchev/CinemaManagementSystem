using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CinemaManagementSystem.Models;

namespace CinemaManagementSystem
{
    public partial class CitiesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<City> citiesList_GetData()
        {
            CinemaContext db = new CinemaContext();
            return db.Cities.Select(s => s);
        }
    }
}