using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test23
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null)
            {
                Response.Redirect("LoginClient.aspx");
            }
            else
            {
                if (Session["New"] != null)
                {
                    Filldata();
                }
            }
        }

        StringBuilder sb = new StringBuilder();

        public void Filldata()
        {
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;

            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;

            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            TextBox9.Visible = false;
            TextBox10.Visible = false;
            TextBox11.Visible = false;
            TextBox12.Visible = false;
            lblId.Text = Session["New"].ToString();
            string status = "Pending";
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from RequestPayment_tbl where IdCard='" + lblId.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sb.Append("<center>");
            sb.Append("<h1>Send Payment</h1>");
            sb.Append("<hr/>");
            sb.Append("<table border=1>");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                sb.Append("<th>");
                sb.Append(dc.ColumnName.ToUpper());
                sb.Append("</th>");
            }
            sb.Append("</tr>");

            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(dr[dc.ColumnName].ToString());
                    sb.Append("</th>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            sb.Append("</center>");
            Panel1.Controls.Add(new Label { Text = sb.ToString() });
            sqlconn.Close();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                lblError.Text = "Please insert transaction ID";
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;


                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
                TextBox9.Visible = false;
                TextBox10.Visible = false;
                TextBox11.Visible = false;
                TextBox12.Visible = false;
                Response.Headers.Add("Refresh", "0");
            }
            else
            {
                if(txtSearch.Text != "")
                {
                    SearchByTransactionID();
                }
            }
        }

        public void SearchByTransactionID()
        {
            string numbers = txtSearch.Text;
            if (numbers.Length > 10)
            {
                lblError.Text = "Please insert a 10 digit number Transaction ID";
                Response.Headers.Add("Refresh", "2");

            }
            else
            {
                string connectionstrin = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Admindtb.mdf;Integrated Security=True;Connect Timeout=30";
                System.Data.SqlClient.SqlConnection conn = new SqlConnection(connectionstrin);
                conn.Open();
                string checkuser = "select count(*) from RequestPayment_tbl where Id ='" + txtSearch.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();
                if (temp == 1)
                {

                    string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    sqlconn.Open();
                    string sqlquery = "select Name, Surname, IdCard, DateIn, IBAN, Amount, Valut, Exchange, ReceiverId, Status, DateOut FROM RequestPayment_tbl where Id='" + txtSearch.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        TextBox2.Text = Convert.ToString(dr.GetValue(0));
                        TextBox3.Text = Convert.ToString(dr.GetValue(1));
                        TextBox4.Text = Convert.ToString(dr.GetValue(2));
                        TextBox5.Text = Convert.ToString(dr.GetValue(3));
                        TextBox6.Text = Convert.ToString(dr.GetValue(4));
                        TextBox7.Text = Convert.ToString(dr.GetValue(5));
                        TextBox8.Text = Convert.ToString(dr.GetValue(6));
                        TextBox9.Text = Convert.ToString(dr.GetValue(7));
                        TextBox10.Text = Convert.ToString(dr.GetValue(8));
                        TextBox11.Text = Convert.ToString(dr.GetValue(9));
                        TextBox12.Text = Convert.ToString(dr.GetValue(10));

                        Label3.Visible = true;
                        Label4.Visible = true;
                        Label5.Visible = true;
                        Label6.Visible = true;
                        Label7.Visible = true;
                        Label8.Visible = true;
                        Label9.Visible = true;
                        Label10.Visible = true;
                        Label11.Visible = true;
                        Label12.Visible = true;
                        Label13.Visible = true;

                        TextBox2.Visible = true;
                        TextBox3.Visible = true;
                        TextBox4.Visible = true;
                        TextBox5.Visible = true;
                        TextBox6.Visible = true;
                        TextBox7.Visible = true;
                        TextBox8.Visible = true;
                        TextBox9.Visible = true;
                        TextBox10.Visible = true;
                        TextBox11.Visible = true;
                        TextBox12.Visible = true;
                    }
                    sqlconn.Close();
                }
                else
                {
                    lblError.Text = "Transaction ID does not exist!";
                    Response.Headers.Add("Refresh", "2");
                }
            }
           
        }

        public void catchError()
        {
            
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            lblError.Text = "";
            lblSuccess.Text = "";

            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;

            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;

            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            TextBox9.Visible = false;
            TextBox10.Visible = false;
            TextBox11.Visible = false;
            TextBox12.Visible = false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
  }