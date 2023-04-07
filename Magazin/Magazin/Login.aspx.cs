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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection();

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM UserAcc where Email='" + emailText.Text + "' AND Password='" + passwordText.Text + "'", myCon);
            DataTable dataTable = new DataTable();

            sqlData.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                Session["username"] = emailText.Text;
                Response.Redirect("Default.aspx");
                //Label1.Text = "Login Succesful!";
            }
            else
            {
                Label1.Text = "Email or password wrong!";
            }
        }
    }
}