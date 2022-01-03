using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            AdminInfo a = new AdminInfo();
            this.Close();
            a.Show();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        public void VerifyPosition()
        {
            label9.Visible = false;
            string username = Class1.uname;
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\User\Desktop\ATM-master\Admindtb.mdf;Integrated Security = True; Connect Timeout = 30");

            Con.Open();
            string query1 = "select Position from Admin_tbl where Username='" + username.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query1, Con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                label9.Text = dr.GetValue(0).ToString();
                // textBox1.Text = dr.GetValue(0).ToString();
            }
            Con.Close();
            if(label9.Text == "Employee")
            {
                guna2ImageButton5.Enabled = false;
                guna2ImageButton6.Enabled = false;
                guna2ImageButton3.Enabled = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            VerifyPosition();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            this.Close();
            c.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            this.Close();
            p.Show();

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Valut v = new Valut();
            this.Close();
            v.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            this.Close();
            t.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            this.Close();
            d.Show();
        }
    }
}
