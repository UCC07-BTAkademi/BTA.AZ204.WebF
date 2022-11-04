using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class DTwQueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnkbDTwTestQS_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("DTwTestQS.aspx?Value={0}&id={1}", tboxValue.Text, 1));
        }
    }
}