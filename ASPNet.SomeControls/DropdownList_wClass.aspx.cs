using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DropdownList_wClass : System.Web.UI.Page
    {
        public class City
        {
            public string PlateNo { get; set; }
            public string CityName { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<City> cities = new List<City>();

            cities.Add(new City { CityName = "Adana", PlateNo = "01" });
            cities.Add(new City { CityName = "Ankara", PlateNo = "06" });
            cities.Add(new City { CityName = "Balıkesir", PlateNo = "10" });
            cities.Add(new City { CityName = "Diyarbakır", PlateNo = "21" });
            cities.Add(new City { CityName = "Elazığ", PlateNo = "23" });
            cities.Add(new City { CityName = "Mersin", PlateNo = "33" });
            cities.Add(new City { CityName = "Malatya", PlateNo = "44" });

            ddlsCity.DataSource = cities;
            ddlsCity.DataTextField = "CityName";
            ddlsCity.DataValueField = "PlateNo";
            ddlsCity.DataBind();
        }
    }
}