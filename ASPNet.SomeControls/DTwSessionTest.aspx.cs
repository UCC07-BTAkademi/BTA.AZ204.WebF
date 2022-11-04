using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DTwSessionTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["value1"] != null)
                {
                    lbelSessions.Text = "Value1 = " + Session["value1"].ToString();
                }

                if (Session["value2"] != null)
                {
                    lbelSessions.Text += " ve Value2 = " + Session["value2"].ToString();
                }

                if (Session["colors"] != null)
                {
                    lbelSessions.Text += " ve renkler : ";

                    List<string> colors = new List<string>();

                    colors = (List<string>)Session["colors"];

                    foreach (var item in colors)
                    {
                        lbelSessions.Text += " " + item + ", ";
                    }

                    colors = null;
                }


            }
        }
    }
}