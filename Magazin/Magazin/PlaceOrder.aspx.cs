using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Magazin
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

            myCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO CardDetails VALUES (@Fname, @Lname, @CardNr, @ExpiryDate, @CVV, @Address)", myCon);
            cmd.Parameters.AddWithValue("@Fname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Lname", TextBox2.Text);
            cmd.Parameters.AddWithValue("@CardNr", TextBox3.Text);
            cmd.Parameters.AddWithValue("@ExpiryDate", TextBox4.Text);
            cmd.Parameters.AddWithValue("@CVV", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox6.Text);

            cmd.ExecuteNonQuery();
            myCon.Close();

            Response.Write("<script>alert('Payment Successful');</script>");
            Session["address"] = TextBox6.Text;
            Response.Redirect("Pdf_generate.aspx");
        }
    }
}