using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkbAdRotator_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/AdRotator.aspx");
        }
        protected void lnkbDropdownList_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DropdownList.aspx");
        }
        protected void lnkbDropdownListwCode_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DropdownList_wCode.aspx");
        }
        protected void lnkbDropdownListwClass_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DropdownList_wClass.aspx");
        }
        protected void lnkbFileUpload_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/FileUpload.aspx");
        }
        protected void lnkbDTwCookie_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DTwCookie.aspx");
        }
        protected void lnkbDTwQueryString_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DTwQueryString.aspx");
        }
        protected void lnkbDTwSession_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DTwSession.aspx");
        }
        protected void lnkbDGXML_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/DGXML.aspx");
        }
    }
}