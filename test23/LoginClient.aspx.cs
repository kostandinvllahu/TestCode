using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace test23
{
    public partial class LoginClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["New"] != null)
            {
                Session.RemoveAll();
            }
            else
            {
                Session.RemoveAll();
            }
            
            //Response.Redirect("LoginClient.aspx");//CatchError();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionstrin = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\User\Desktop\ATM-master\Admindtb.mdf;Integrated Security = True; Connect Timeout = 30";
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(connectionstrin);
            conn.Open();
            string checkuser = "select count(*) from Client_tbl where IdCard='" + txtIdCard.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                string checkpassword = "select password from Client_tbl where IdCard='" + txtIdCard.Text + "'";
                SqlCommand passComm = new SqlCommand(checkpassword, conn);
                conn.Open();
                string password = passComm.ExecuteScalar().ToString();
                if(password == txtPassword.Text)
                {
                   // CatchError();
                    Session["New"] = txtIdCard.Text;
                    Response.Write("Password is correct");
                   // Session["IdCard"] = txtIdCard;
                    Response.Redirect("MainMenu.aspx");
                }
                else
                {
                    Response.Write("Password is not correct");
                }
            }
            else
            {
                Response.Write("Id Card Number is not correct");
            }
        }
    }
}