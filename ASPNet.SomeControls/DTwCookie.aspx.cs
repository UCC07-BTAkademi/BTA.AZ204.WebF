using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DTwCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnkbDTwTestCookie_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DTwCookieTestPage.aspx");
        }
        protected void btonCreateCookie_Click(object sender, EventArgs e)
        {
            HttpCookie UserCookie = new HttpCookie("User");

            UserCookie.Value = tboxValue.Text;
            UserCookie.Expires = DateTime.Now.AddHours(1);

            Response.Cookies.Add(UserCookie);
            
            lbelMessage.Text = "Cookie created !";
        }
    }
}