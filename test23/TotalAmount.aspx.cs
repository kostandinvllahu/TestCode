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
    public partial class TotalAmount : System.Web.UI.Page
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
                    FllAmount();
                }
            }
        }
        public void FllAmount()
        {
            txtAmount.Enabled = false;
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string sqlquery = "select Deposit FROM Client_tbl where IdCard='" + lblId.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtAmount.Text = Convert.ToString(dr.GetValue(0));
            }
            sqlconn.Close();
        }
    }
}