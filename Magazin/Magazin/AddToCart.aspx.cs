using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Magazin
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["buyitems"] == null)
                {
                    Button1.Enabled = false;
                }
                else
                {
                    Button1.Enabled = true;
                }

                Session["addproduct"] = "false";

                DataTable dataTable = new DataTable();
                DataRow dataRow;

                dataTable.Columns.Add("sno");
                dataTable.Columns.Add("pid");
                dataTable.Columns.Add("pname");
                dataTable.Columns.Add("pimage");
                dataTable.Columns.Add("pprice");
                dataTable.Columns.Add("pquantity");
                dataTable.Columns.Add("ptotalprice");

                if (Request.QueryString["id"] != null)
                {
                    if (Session["buyitems"] == null)
                    {
                        dataRow = dataTable.NewRow();

                        SqlConnection myCon = new SqlConnection();
                        myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Product1 WHERE ProductId=" + Request.QueryString["id"], myCon);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        dataRow["sno"] = 1;
                        dataRow["pid"] = dataSet.Tables[0].Rows[0]["ProductId"].ToString();
                        dataRow["pname"] = dataSet.Tables[0].Rows[0]["Pname"].ToString();
                        dataRow["pimage"] = dataSet.Tables[0].Rows[0]["Pimage"].ToString();
                        dataRow["pprice"] = dataSet.Tables[0].Rows[0]["Pprice"].ToString();
                        dataRow["pquantity"] = Request.QueryString["quantity"];

                        int price = Convert.ToInt32(dataSet.Tables[0].Rows[0]["pprice"].ToString());
                        int Quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                        int TotalPrice = price * Quantity;
                        dataRow["ptotalprice"] = TotalPrice;

                        dataTable.Rows.Add(dataRow);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                        Session["buyitems"] = dataTable;
                        Button1.Enabled = true;

                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("AddToCart.aspx");
                    }
                    else
                    {
                        dataTable = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dataTable.Rows.Count;

                        dataRow = dataTable.NewRow();
                        SqlConnection myCon = new SqlConnection();
                        myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Product1 WHERE ProductId=" + Request.QueryString["id"], myCon);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        dataRow["sno"] = sr + 1;
                        dataRow["pid"] = dataSet.Tables[0].Rows[0]["ProductId"].ToString();
                        dataRow["pname"] = dataSet.Tables[0].Rows[0]["Pname"].ToString();
                        dataRow["pimage"] = dataSet.Tables[0].Rows[0]["Pimage"].ToString();
                        dataRow["pprice"] = dataSet.Tables[0].Rows[0]["Pprice"].ToString();
                        dataRow["pquantity"] = Request.QueryString["quantity"];

                        int price = Convert.ToInt32(dataSet.Tables[0].Rows[0]["pprice"].ToString());
                        int Quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                        int TotalPrice = price * Quantity;
                        dataRow["ptotalprice"] = TotalPrice;

                        dataTable.Rows.Add(dataRow);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                        Session["buyitems"] = dataTable;
                        Button1.Enabled = true;

                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("AddToCart.aspx");
                    }
                }
                else
                {
                    dataTable = (DataTable)Session["buyitems"];
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();

                    if (GridView1.Rows.Count > 0)
                    {
                        GridView1.FooterRow.Cells[4].Text = "Total Amount";
                        GridView1.FooterRow.Cells[5].Text = grandtotal().ToString();
                    }
                }
            }

            string OrderDate = DateTime.Now.ToShortDateString();
            Session["orderdate"] = OrderDate;
            orderid();
        }

        public int grandtotal()
        {
            DataTable dataTable = new DataTable();
            dataTable = (DataTable)Session["buyitems"];

            int nrow = dataTable.Rows.Count;
            int i = 0;
            int totalprice = 0;

            while (i < nrow)
            {
                totalprice = totalprice + Convert.ToInt32(dataTable.Rows[i]["pprice"].ToString());
                i = i + 1;
            }

            return totalprice;
        }

        public void orderid()
        {
            String alpha = "abCdefghIjklmNopqrStuvwXyz123456789";
            Random r = new Random();

            char[] myArray = new char[5];
            for (int i = 0; i < 5; ++i)
            {
                myArray[i] = alpha[(int)(35 * r.NextDouble())];
            }

            String orderId;
            orderId = "Order_id: " + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString()
                + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(myArray) + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            Session["orderid"] = orderId;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = (DataTable)Session["buyitems"];

            for (int i = 0; i <= dataTable.Rows.Count - 1; ++i)
            {
                int sr, sr1;
                string qdata, dtdata;

                sr = Convert.ToInt32(dataTable.Rows[i]["sno"].ToString());
                TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];

                qdata = cell.Text;
                dtdata = sr.ToString();

                sr1 = Convert.ToInt32(qdata);

                if (sr == sr1)
                {
                    dataTable.Rows[i].Delete();
                    dataTable.AcceptChanges();

                    break;
                }
            }

            for (int i = 1; i <= dataTable.Rows.Count; ++i)
            {
                dataTable.Rows[i - 1]["sno"] = i;
                dataTable.AcceptChanges();
            }

            Session["buyitems"] = dataTable;
            Response.Redirect("AddToCart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = (DataTable)Session["buyitems"];

            for (int i = 0; i <= dataTable.Rows.Count - 1; ++i)
            {
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

                myCon.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO OrderDetails (orderid, sno, productid, productname, price, quantity, orderdate) VALUES('" + Session["orderid"] + "',"
                    + dataTable.Rows[i]["sno"] + "," + dataTable.Rows[i]["pid"] + ",'" + dataTable.Rows[i]["pname"] + "'," + dataTable.Rows[i]["pprice"] + ","
                    + dataTable.Rows[i]["pquantity"] + ",'" + Session["orderdate"] + "')", myCon);
                cmd.ExecuteNonQuery();

                myCon.Close();
            }

            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (GridView1.Rows.Count.ToString() == "0")
                {
                    Response.Write("<script>alert('Your cart is empty. You cannot place an order.');</script>");
                }
                else
                {
                    Response.Redirect("PlaceOrder.aspx");
                }
            }
        }
    }
}