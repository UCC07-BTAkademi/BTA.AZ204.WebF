using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DTwTestQS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbelMessage.Text = Request.QueryString["Value"];
        }
    }
}