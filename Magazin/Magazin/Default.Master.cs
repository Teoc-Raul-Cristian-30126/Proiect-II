using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Magazin
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next(1, 5);
            Image2.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AddToCart.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/anrosa_?igshid=MzRlODBiNWFlZA==");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://m.facebook.com/anrosastore/");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/adidasoriginals?lang=en");
        }
    }
}