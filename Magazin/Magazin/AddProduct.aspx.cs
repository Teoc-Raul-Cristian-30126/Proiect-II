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
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

            if (FileUpload1.HasFile)
            {
                string filename = FileUpload1.PostedFile.FileName;
                string filepath = "Images/" + FileUpload1.FileName;

                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + filename);

                myCon.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Product1 VALUES('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + filepath + "', '" + TextBox4.Text + "')", myCon);

                cmd.ExecuteNonQuery();
                myCon.Close();

                Response.Redirect("Default.aspx");
            }
        }
    }
}