using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test23
{
    public partial class MainMenu : System.Web.UI.Page
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
                    lblId.Visible = false;
                    lblId.Text = Session["New"].ToString();
                }
                // Response.Write(Session["IdCard"]);
            }
            FllAmount();
        }

        public void FllAmount()
        {
           // txtAmount.Enabled = false;
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Deposit, Valut C FROM Client_tbl where IdCard='" + lblId.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblAmount.Text = Convert.ToString(dr.GetValue(0));
                lblCurrency.Text = Convert.ToString(dr.GetValue(1));
            }
            sqlconn.Close();
        }

        protected void btnSettings_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Settings.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendMoney.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("RequestMoney.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("TotalAmount.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("LoginClient.aspx");
        }
    }
}