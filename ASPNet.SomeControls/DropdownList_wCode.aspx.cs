using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DropdownList_wCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlsCity.Items.Add(new ListItem { Text = "Adana", Value = "01" });
            ddlsCity.Items.Add(new ListItem { Text = "Ankara", Value = "06" });
            ddlsCity.Items.Add(new ListItem { Text = "Balıkesir", Value = "10" });
            ddlsCity.Items.Add(new ListItem { Text = "Diyarbakır", Value = "21" });
            ddlsCity.Items.Add(new ListItem { Text = "Elazığ", Value = "23" });
            ddlsCity.Items.Add(new ListItem { Text = "Mersin", Value = "33" });
            ddlsCity.Items.Add(new ListItem { Text = "Malatya", Value = "44" });
        }
    }
}