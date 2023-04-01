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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection();

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO UserAcc (FirstName, LastName, Email, Gender, Address, Phone, Password)" +
                                            " VALUES (@FirstName, @LastName, @Email, @Gender, @Address, @Phone, @Password)", myCon);

            cmd.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
            cmd.Parameters.AddWithValue("@LastName", LastNameText.Text);
            cmd.Parameters.AddWithValue("@Email", EmailText.Text);
            cmd.Parameters.AddWithValue("@Gender", GenderSelect.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Address", AddressText.Text);
            cmd.Parameters.AddWithValue("@Phone", PhoneText.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordText.Text);

            cmd.ExecuteNonQuery();
            myCon.Close();

            Label1.Text = "Registered Successfully!";
        }
    }
}