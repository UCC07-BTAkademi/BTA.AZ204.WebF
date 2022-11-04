using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace ASPNet.SomeControls
{
    public partial class DGXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            dataSet.ReadXml(Server.MapPath("~/Data/Employees.xml"));

            dgrdEmployees.DataSource= dataSet;  

            dgrdEmployees.DataBind();   
        }
    }
}