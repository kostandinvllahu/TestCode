using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;
namespace test23
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            if (Session["New"] == null)
            {
                Response.Redirect("LoginClient.aspx");
            }
            else
            {
                if (Session["New"] != null)
                {
                    lblId.Text = Session["New"].ToString();
                    /*KOD TEST PER TE NXJERR TE DHENAT NGA ID*/
                    ///  if (!Page.IsPostBack)
                    //{
                    string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "select username, lastname, phone, idcard from Client_tbl where idcard='" + lblId.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<center>");
                    sb.Append("<h1>Your Persoanl Information</h1>");
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
                    //}
                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtpassword.Text = "";
            txtPhone.Text = "";
            chkBoth.Checked = false;
            chkNumber.Checked = false;
            chkPassword.Checked = false;
            txtpassword.BorderColor = System.Drawing.Color.Black;
            txtPhone.BorderColor = System.Drawing.Color.Black;
            lblError.Text = "";
            lblSuccess.Text = "";
        }

        public void check()
        {
            if(chkBoth.Checked == false || chkNumber.Checked == false || chkPassword.Checked == false)
            {
                lblError.Text = "Please choose one of the options";
                clear();
            }
        }



        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           
            
               /* // update password
                if (chkPassword.Checked == true)
                {
                    if (txtpassword.Text == "")
                    {
                        txtpassword.BorderColor = System.Drawing.Color.Red;
                        lblError.Text = "Please fill the Password field";
                    }
                    else
                    {
                        //Update query for password
                        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                        SqlConnection con = new SqlConnection(mainconn);
                        SqlCommand cmd = new SqlCommand(@"UPDATE Client_tbl SET[password] = '" + txtpassword.Text + "' WHERE [IdCard]='" + lblId.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblSuccess.Text = "Password is updated succesfully, Page will refresh automatically";
                        //clear();
                        Response.Headers.Add("Refresh", "2");
                        con.Close();
                    }
                }
                //Update number
                if (chkNumber.Checked == true)
                {
                    if (txtPhone.Text == "")
                    {
                        txtPhone.BorderColor = System.Drawing.Color.Red;
                        lblError.Text = "Please fill the Number field";
                    }
                    else
                    {
                        //Update query
                        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                        SqlConnection con = new SqlConnection(mainconn);
                        SqlCommand cmd = new SqlCommand(@"UPDATE Client_tbl SET[Phone]='" + txtPhone.Text + "'WHERE[IdCard]='" + lblId.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblSuccess.Text = "Phone is updated successfully, Page will refresh automatically";
                        Response.Headers.Add("Refresh", "2");
                        con.Close();
                    }
                }

                if (chkBoth.Checked == true)
                {
                    if (txtpassword.Text == "" || txtPhone.Text == "")
                    {
                        txtPhone.BorderColor = System.Drawing.Color.Red;
                        txtpassword.BorderColor = System.Drawing.Color.Red;
                        lblError.Text = "Please fill both fields";
                    }
                    else
                    {
                        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                        SqlConnection con = new SqlConnection(mainconn);
                        SqlCommand cmd = new SqlCommand(@"UPDATE Client_tbl SET[Phone]='" + txtPhone.Text + "', [password]='" + txtpassword.Text + "'WHERE[IdCard]='" + lblId.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblSuccess.Text = "Phone and password are updated successfully, Page will refresh automatically";
                        Response.Headers.Add("Refresh", "2");
                        con.Close();
                    }
                }*/
            
        }

        protected void gvContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void chkNumber_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (chkBoth.Checked == false && chkNumber.Checked == false && chkPassword.Checked == false)
            {
                lblError.Text = "Please choose one of the options";
                // clear();
            }
            else
            {
                // update password
                if (chkPassword.Checked == true)
                {
                    if (txtpassword.Text == "")
                    {
                        txtpassword.BorderColor = System.Drawing.Color.Red;
                        lblError.Text = "Please fill the Password field";
                    }
                    else
                    {
                        //Update query for password
                        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                        SqlConnection con = new SqlConnection(mainconn);
                        SqlCommand cmd = new SqlCommand(@"UPDATE Client_tbl SET[password] = '" + txtpassword.Text + "' WHERE [IdCard]='" + lblId.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblSuccess.Text = "Password is updated succesfully, Page will refresh automatically";
                        //clear();
                        Response.Headers.Add("Refresh", "2");
                        con.Close();
                    }
                }
                //Update number
                if (chkNumber.Checked == true)
                {
                    if (txtPhone.Text == "")
                    {
                        txtPhone.BorderColor = System.Drawing.Color.Red;
                        lblError.Text = "Please fill the Number field";
                    }
                    else
                    {
                        //Update query
                        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                        SqlConnection con = new SqlConnection(mainconn);
                        SqlCommand cmd = new SqlCommand(@"UPDATE Client_tbl SET[Phone]='" + txtPhone.Text + "'WHERE[IdCard]='" + lblId.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblSuccess.Text = "Phone is updated successfully, Page will refresh automatically";
                        Response.Headers.Add("Refresh", "2");
                        con.Close();
                    }
                }

                if (chkBoth.Checked == true)
                {
                    if (txtpassword.Text == "" || txtPhone.Text == "")
                    {
                        txtPhone.BorderColor = System.Drawing.Color.Red;
                        txtpassword.BorderColor = System.Drawing.Color.Red;
                        lblError.Text = "Please fill both fields";
                    }
                    else
                    {
                        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                        SqlConnection con = new SqlConnection(mainconn);
                        SqlCommand cmd = new SqlCommand(@"UPDATE Client_tbl SET[Phone]='" + txtPhone.Text + "', [password]='" + txtpassword.Text + "'WHERE[IdCard]='" + lblId.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblSuccess.Text = "Phone and password are updated successfully, Page will refresh automatically";
                        Response.Headers.Add("Refresh", "2");
                        con.Close();
                    }
                }
            }
        }
    }
}