using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.SomeControls
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btonUpload_Click(object sender, EventArgs e)
        {
            btonUpload.Enabled = false;

            if (fuplFile.HasFile)
            {
                foreach (HttpPostedFile uploadedFile in fuplFile.PostedFiles)
                {
                    uploadedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Files/"), uploadedFile.FileName));

                    lbelUploadedFiles.Text += String.Format("{0}<br />", uploadedFile.FileName);
                }

            }

            btonUpload.Enabled = true;
        }
    }
}