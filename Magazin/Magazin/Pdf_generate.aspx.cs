using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Magazin
{
    public partial class Pdf_generate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Orderid = Session["orderid"].ToString();
            Label1.Text = Orderid;
            findorderdate(Label2.Text);
            string Address = Session["address"].ToString();
            Label3.Text = Address;
            showgrid(Label1.Text);
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        [Obsolete]
        protected void Button1_Click(object sender, EventArgs e)
        {
            exportpdf();
        }

        [Obsolete]
        private void exportpdf()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=OrderInvoice.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            Panel1.RenderControl(htmlTextWriter);

            StringReader stringReader = new StringReader(stringWriter.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            htmlparser.Parse(stringReader);
            pdfDoc.Close();

            Response.Write(pdfDoc);
            Response.End();
        }

        private void findorderdate(String Orderid)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetails where orderid='" + Label1.Text + "'", myCon);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                Label2.Text = dataSet.Tables[0].Rows[0]["Orderdate"].ToString();
            }

            myCon.Close();
        }

        private void showgrid(String orderid)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("sno");
            dt.Columns.Add("productid");
            dt.Columns.Add("productname");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");
            dt.Columns.Add("totalprice");

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetails where orderid='" + Label1.Text + "'", myCon);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            int totalrows = ds.Tables[0].Rows.Count;
            int i = 0;
            int grandtotal = 0;

            while (i < totalrows)
            {
                dr = dt.NewRow();
                dr["sno"] = ds.Tables[0].Rows[i]["sno"].ToString();
                dr["productid"] = ds.Tables[0].Rows[i]["productid"].ToString();
                dr["productname"] = ds.Tables[0].Rows[i]["productname"].ToString();
                dr["quantity"] = ds.Tables[0].Rows[i]["quantity"].ToString();
                dr["price"] = ds.Tables[0].Rows[i]["price"].ToString();

                int price = Convert.ToInt32(ds.Tables[0].Rows[i]["price"].ToString());
                int quantity = Convert.ToInt16(ds.Tables[0].Rows[i]["quantity"].ToString());
                int totalprice = price * quantity;

                dr["totalprice"] = totalprice;
                grandtotal += totalprice;

                dt.Rows.Add(dr);
                i += 1;
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();

            Label4.Text = grandtotal.ToString();
        }
    }
}