using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DropdownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ddlsCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cityName = ddlsCity.SelectedItem.Text;
            string plateNo = ddlsCity.SelectedItem.Value;

            lbelMessage.Text = "Şehir: " + cityName + " - Plaka No: " + plateNo;
        }
    }
}