using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Web.Helpers;
using System.Web.Services.Description;

namespace Magazin
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Orice cod suplimentar necesar în momentul încărcării paginii
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string nameValue = name.Text;
            string emailValue = email.Text;
            string messageValue = message.Text;

            // Exemplu de trimitere  a unui email
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("pustaibogdan16@gmail.com"); // Adresa ta de email
            mail.To.Add(emailValue); // Adresa introdusă în câmpul de email
            mail.Subject = "New Contact Us Message";
            mail.Body = $"Name: {nameValue}<br />Email: {emailValue}<br />Message: {messageValue}";
            mail.IsBodyHtml = true;

           using(SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new System.Net.NetworkCredential("pustaibogdan16@gmail.com", "syrqajhovuwxgxfm");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

            // Afișați un mesaj de succes sau redirecționați către o altă pagină
            Response.Redirect("Default.aspx");
        }
    }
}