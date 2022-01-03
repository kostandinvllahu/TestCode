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
    public partial class SendMoney : System.Web.UI.Page
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
                    lblId.Text = Session["New"].ToString();
                    string status = "Pending";
                    string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "select Id, Name, Surname, IdCard, DateIn, IBAN, Amount,Valut,Exchange, ReceiverId, Status, DateOut from RequestPayment_tbl where ReceiverId='" + lblId.Text + "' AND Status='" + status + "'";
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
                    filldata();
                }
            }
        }
        public void filldata()
        {
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtIdCard.Enabled = false;
            txtIBAN.Enabled = false;
            txtTotalAmount.Enabled = false;
            txtReceiverID.Enabled = false;
            txtExchange.Enabled = false;
            //txtAmount.Enabled = false;
           // txtDatIn.Enabled = false;
            txtStatus.Enabled = false;
            txtDateOut.Enabled = false;
            txtTotalAmount.Enabled = false;
           // txtDatIn.Text = DateTime.Now.ToString("D").ToString();
            txtDateOut.Text = DateTime.Now.ToString("D").ToString();

            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Username, Lastname, IdCard,IBAN, Deposit FROM Client_tbl where idcard='" + lblId.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = (string)dr.GetValue(0);
                txtSurname.Text = (string)dr.GetValue(1);
                txtIdCard.Text = (string)dr.GetValue(2);
                txtIBAN.Text = (string)dr.GetValue(3);
                txtTotalAmount.Text = (string)dr.GetValue(4);
            }
            sqlconn.Close();

        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtIdCard_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDatIn_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtIBAN_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtRecID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {



        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            verify();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtRecID.Text = "";
            txtExchange.Text = "";
            txtReceiverID.Text = "";
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }



        public void exchangeRate()
        {
           // txtexchange.Enabled = false;

            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Exchange FROM RequestPayment_tbl where Id='" + txtRecID.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                txtExchange.Text = Convert.ToString(dr.GetValue(0));
            }
            sqlconn.Close();

        }


        //The value of sending payment
        int sendPayment = 0;
        //The value of current total amount of cash in bank
        int UsersAmount = 0;
        //The value of total left after transaction is done
        int totalAmount = 0;
        //the user will get like
        double deposit = 0;

        public void verify()
        {
         if(CheckBox1.Checked == true && CheckBox2.Checked == true || CheckBox1.Checked == false && CheckBox2.Checked == false)
            {
                lblError.Text = "Please choose only one action!";
                Response.Headers.Add("Refresh", "2");
            }

            if (CheckBox1.Checked == true)
            {
                //Send money by transaction ID
                if (txtAmount.Text == "" && txtRecID.Text == "" || txtAmount.Text == "" || txtRecID.Text == "")
                {
                    lblError.Text = "Please fill both fields!";
                    Response.Headers.Add("Refresh", "2");

                }
                else
                { 
                    sendPayment = Convert.ToInt32(txtAmount.Text);
                    UsersAmount = Convert.ToInt32(txtTotalAmount.Text);
                    totalAmount = UsersAmount - sendPayment;
                    txtTotalAmount.Text = Convert.ToString(totalAmount);
                    if (totalAmount < 0)
                    {
                        lblError.Text = "Transaction failed due to insufficient amound of founds!";
                        Response.Headers.Add("Refresh", "2");
                    }
                    if(totalAmount >= 0)
                    {
                        
                        string str = txtRecID.Text;
                        //int strLength = str.Length;
                       if(str.Length > 10)
                        {
                            lblError.Text = "Please insert the 10 digit Transaction ID number";
                            Response.Headers.Add("Refresh", "2");
                        }
                        else
                        {
                            checkTransactionId();
                        }
                        
                    }
                    }
                }
         if(CheckBox2.Checked == true)
            {
                //Delete request by transaction ID
                txtStatus.Text = "Payment Request Denied";
                deleteRequest();
                lblSuccess.Text = "Request is deleted succesfully";
                Response.Headers.Add("Refresh", "2");
            }
        }

        public void deleteRequest()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlCommand comand = new SqlCommand(@"UPDATE RequestPayment_tbl SET[Status]='" + txtStatus.Text + "',[DateOut]='" + txtDateOut.Text + "'WHERE[Id]='" + txtRecID.Text + "'", con);
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        public void fetchReceiverId()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Deposit FROM Client_tbl where IdCard='" + txtReceiverID.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                deposit = Convert.ToInt32(dr.GetValue(0));
            }
            sqlconn.Close();
        }

        public void checkTransactionId()
        {
          //  string receiverID = null;
                            string connectionstrin = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Admindtb.mdf;Integrated Security=True;Connect Timeout=30";
                            System.Data.SqlClient.SqlConnection conn = new SqlConnection(connectionstrin);
                            conn.Open();
                            string checkuser = "select count(*) from RequestPayment_tbl where Id ='" + txtRecID.Text + "'";
                            SqlCommand com = new SqlCommand(checkuser, conn);
                            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                            conn.Close();
            if (temp == 1)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();
                string sqlquery = "select IdCard FROM RequestPayment_tbl where Id='" + txtRecID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    txtReceiverID.Text = Convert.ToString(dr.GetValue(0));
                }
                sqlconn.Close();

                exchangeRate();
                 int exchange = Convert.ToInt32(txtExchange.Text);
                 double afterExhchange = sendPayment / exchange;
                fetchReceiverId();
                deposit += afterExhchange;
                //txtTotalAmount.Text = Convert.ToString(deposit);


                //string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(mainconn);
                SqlCommand comand = new SqlCommand(@"UPDATE Client_tbl SET[Deposit]='" + deposit + "'WHERE[IdCard]='" + txtReceiverID.Text + "'", con);
                con.Open();
                comand.ExecuteNonQuery();
                con.Close();
                reduceCash();
                txtStatus.Text = "Transaction Approved";
                updateStatusAndDate();
                lblSuccess.Text = "Payment is made succeessfully";
                                 Response.Headers.Add("Refresh", "2");
                //Kjo punon tani beje qe kur cohen leket te zbriten thjesht nje update query
                //ku merr totalAmound dhe e ben update ne dtb
                             }
                             else
                             {
                                 lblError.Text = "Transaction ID does not exist!";
                                 Response.Headers.Add("Refresh", "2");
            }
        }
        public void reduceCash()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlCommand comand = new SqlCommand(@"UPDATE Client_tbl SET[Deposit]='" + txtTotalAmount.Text + "'WHERE[IdCard]='" + lblId.Text + "'", con);
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        public void updateStatusAndDate()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            SqlCommand comand = new SqlCommand(@"UPDATE RequestPayment_tbl SET[Status]='" + txtStatus.Text + "',[DateOut]='"+txtDateOut.Text+"'WHERE[Id]='" + txtRecID.Text + "'", con);
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            verify();
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}