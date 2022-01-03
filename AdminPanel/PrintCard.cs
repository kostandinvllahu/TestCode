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
    public partial class PrintCard : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\User\Desktop\ATM-master\Admindtb.mdf;Integrated Security = True; Connect Timeout = 30");

        public void populate()
        {
            Con.Open();
             string Myquery = "select CardId, CardType, CardBrand, CardNumber,ExpDate, CVV, CardStatus, IBAN from Card_tbl ";
            //String Myquery = "select IdCard";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Client.DataSource = ds.Tables[0];
            Con.Close();
            search.Text = "";
            IBAN.Text = "";
            Con.Open();
             Myquery = "select IBAN, Valut from Client_tbl";
            da = new SqlDataAdapter(Myquery, Con);
            cbuilder = new SqlCommandBuilder(da);
             ds = new DataSet();
            da.Fill(ds);
            dtIban.DataSource = ds.Tables[0];
            Con.Close();
           
        }
        public PrintCard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clients cls = new Clients();
            cls.Show();
            this.Close();
        }

        public void RandomString()
        {
            var chars = "0123456789";
            var numbers = "0123456789";
            var stringChars = new char[16];
            var random = new Random();

           for (int i = 0; i < 2; i++)
           {
               stringChars[i] = chars[random.Next(chars.Length)];
            }
            for (int i = 2; i < 6; i++)
            {
                stringChars[i] = numbers[random.Next(numbers.Length)];
            }
           for (int i = 6; i < 16; i++)
           {
                stringChars[i] = chars[random.Next(chars.Length)];
           }

            var finalString = new String(stringChars);
            // return finalString;
            txtCardNumber.Text = finalString;
        }

        public void Clean()
        {
            IdCard.Text = "";
            txtName.Text = "";
            txtSname.Text = "";
            CardType.Text = "";
            CardBrand.Text = "";
            txtCardNumber.Text = "";
            txtExpDate.Text = "";
            txtCVV.Text = "";
            search.Text = "";
            IBAN.Text = "";
            txtExpDate.ReadOnly = true;
            //=======PER UPDATE CARD STATUS=====//
            btnGenerate.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            IdCard.ReadOnly = false;
        }

        public void CvvGenerator()
        {
            Random rnd = new Random();
            var chars = "0123456789";
            var stringChars = new char[3];
            for (int i=0; i<3; i++)
            {

                stringChars[i] = chars[rnd.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            txtCVV.Text = finalString;
        }
        private void PrintCard_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RandomString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CvvGenerator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username, Lastname from Client_tbl where IdCard='" + IdCard.Text + "'", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr.GetValue(0).ToString();
                txtSname.Text = dr.GetValue(1).ToString();
                txtExpDate.ReadOnly = false;
            }
            Con.Close();

            if (button2.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                Con.Open();
                string Myquery = "select IBAN, Valut from Client_tbl where IdCard = '" + IdCard.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dtIban.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IdCard.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please insert the client ID Card");
                Clean();
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Card_tbl(CardID, CardType, CardBrand, CardNumber, ExpDate, CVV, CardStatus, IBAN) VALUES('" + IdCard.Text + "','" + CardType.Text + "','" + CardBrand.Text + "','" + txtCardNumber.Text + "','" + txtExpDate.Text + "','" + txtCVV.Text + "','" + CardStatus.Text + "','"+IBAN.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Card Successfully Added!");
                Con.Close();
                populate();
                //updateroomstate();
                Clean();
            }
        }

        private void Client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCardNumber.Text = Client.SelectedRows[0].Cells[3].Value.ToString();
            CardStatus.Text = Client.SelectedRows[0].Cells[6].Value.ToString();
            btnGenerate.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            IdCard.ReadOnly = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "")
            {
                MessageBox.Show("Please Insert Card Number!");
            }
            else
            {
                Con.Open();
                string myquery = "UPDATE Card_tbl set CardStatus='" + CardStatus.Text + "'where CardNumber=" + txtCardNumber.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Card Successfully Edited!");
                Con.Close();
                populate();
                Clean();

            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                Con.Open();
                string Myquery = "select * from Card_tbl where CardId = '" + search.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Client.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void dtIban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IBAN.Text = dtIban.SelectedRows[0].Cells[0].Value.ToString();
           // CardStatus.Text = Client.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
