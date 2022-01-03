using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace test23
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string currentId =  loginAndGetId(txtUser.Text, txtPassword.Text);///merr id per username/pass
            
            UpdateById(currentId, txtLastName.Text);//updaton LastName per kete id
            Session["id"] = currentId;
            Response.Redirect("MainMenu.aspx");
        }
        public string loginAndGetId(string username,string password1)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                System.Data.SqlClient.SqlConnection myCon = new SqlConnection(mainconn);
                myCon.Open();
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = myCon;
                sqlComm.CommandText = "select * from Client_tbl where idcard = '"
                    + username + "' and Password = '" + password1 + "'";
                SqlDataReader sqlPergjigje = sqlComm.ExecuteReader();
                DataTable myDtb = new DataTable();
                string strinPergjigje = "";
                if (sqlPergjigje != null)
                {
                    myDtb.Load(sqlPergjigje);
                    if (myDtb.Rows.Count > 1)
                    {
                        strinPergjigje = myDtb.Rows[0][0].ToString();
                    }
                }
                myCon.Close();
                return strinPergjigje;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error " + ex.Message;
                return "0";
            }
           
            }
        public string UpdateById(string id,string valueToUpdate)
        {
            try
            {
                string connectionstrin = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Admindtb.mdf;Integrated Security=True;Connect Timeout=30";
                System.Data.SqlClient.SqlConnection myCon = new SqlConnection(connectionstrin);
                myCon.Open();
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = myCon;
                sqlComm.CommandText = "update Client_tbl set lastname = '" + valueToUpdate + "' where id = '"
                    + id + "'";
                 sqlComm.ExecuteScalar();
                myCon.Close();
                return "";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error " + ex.Message;
                return "0";
            }

        }
    }
    }
