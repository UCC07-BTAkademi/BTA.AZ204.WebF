using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


namespace Ornek01.WebF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btonOK_Click(object sender, EventArgs e)
        {
            lbelMessage.Text = "Merhaba dünya....";
        }

        protected void btonGonder_Click(object sender, EventArgs e)
        {
            // Mail gönderecek

            string mailfrom = "btdeneme12@hotmail.com";
            string mailto = tboxEMail.Text;
            string sifre = "denemebt12";

            MailMessage mailgonder = new MailMessage(mailfrom, mailto, "Deneme", "Güvenlik Kodu: ");
            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(mailfrom, sifre);

            try
            {
                smtp.Send(mailgonder);
            }
            catch (Exception)
            {

                Server.Transfer("./Hata.aspx");
            }
            finally
            {
                lbelMessage.Text = "Mailiniz başarılı olarak gönderildi....";
            }
            
        }

    }
}