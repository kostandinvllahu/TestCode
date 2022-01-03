using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test23
{
    public partial class RequestMoney : System.Web.UI.Page
    {
        bool flag = false;
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
                    lblId.Text = Session["New"].ToString();

                    string status = "Pending";
                    string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "select * from RequestPayment_tbl where idcard='" + lblId.Text + "' AND Status='" + status + "'";
                    SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    StringBuilder sb = new StringBuilder();
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
                filldata();
                IdGenerator();
                exchangeRate();
            }
        }

      

        public void filldata()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtIdCard.Enabled = false;
            txtIBAN.Enabled = false;
            txtDatIn.Enabled = false;
            txtStatus.Enabled = false;
            txtDatIn.Text = DateTime.Now.ToString("D").ToString();

            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Username, Lastname, IdCard, IBAN, Valut FROM Client_tbl where idcard='" + lblId.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = (string)dr.GetValue(0);
                txtSurname.Text = (string)dr.GetValue(1);
                txtIdCard.Text = (string)dr.GetValue(2);
                txtIBAN.Text = (string)dr.GetValue(3);
                txtValut.Text = (string)dr.GetValue(4);
            }
            sqlconn.Close();

        }

        public void exchangeRate()
        {
            txtValut.Enabled = false;
            txtexchange.Enabled = false;

            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Exchange FROM Valut_tbl where Valut='" + txtValut.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                txtexchange.Text = Convert.ToString(dr.GetValue(0));
            }
            sqlconn.Close();

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clean();
        }
        public void clean()
        {
            txtAmount.Text = "";
            txtRecID.Text = "";
            lblError.Text = "";
            lblSuccess.Text = "";
            txtAmount.BorderColor = System.Drawing.Color.Black;
            txtRecID.BorderColor = System.Drawing.Color.Black;
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text == "" || txtRecID.Text == "")
            {
                txtRecID.BorderColor = System.Drawing.Color.Red;
                txtAmount.BorderColor = System.Drawing.Color.Red;
                lblError.Text = "Please fill both fields";
                
            }

            if(txtAmount.Text != "" && txtRecID.Text != "")
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Client_tbl";
                cmd.Connection = sqlconn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(dr[8].ToString() == txtRecID.Text)
                    {
                        flag = true;
                        break;
                    }
                }
                sqlconn.Close();
                if (flag == true)
                {
                    string dateOut = "-";
                   // int id = 0;
                    sqlconn.Open();
                    cmd = sqlconn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into RequestPayment_tbl values('"+txtID.Text+"','"+txtName.Text+"','"+txtSurname.Text+"','"+txtIdCard.Text+"','"+txtDatIn.Text+"','"+txtIBAN.Text+"','"+txtAmount.Text+"','"+txtValut.Text+"','"+txtexchange.Text+"','"+txtRecID.Text+"','"+txtStatus.Text+"','"+dateOut.ToString()+"')";
                    cmd.ExecuteNonQuery();
                    lblSuccess.Text = "Payment is requested succesfully please wait for the user's answer";
                    Response.Headers.Add("Refresh", "2");
                    sqlconn.Close();
                }
                else
                {
                    lblError.Text = "User doesnt exist";
                }
            }
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void IdGenerator()
        {
            //make an id generator with 4 random digits
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                txtID.Text = Convert.ToString(random.Next());
            }
        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDatIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}