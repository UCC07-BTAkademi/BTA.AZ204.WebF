using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DTwSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btonTestPage_Click(object sender, EventArgs e)
        {
            Session["value1"] = tboxValue1.Text;
            Session["value2"] = tboxValue2.Text;

            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            
            Session["colors"] = colors;
            
            colors = null;

            Response.Redirect("DTwSessionTest.aspx");
        }
    }
}