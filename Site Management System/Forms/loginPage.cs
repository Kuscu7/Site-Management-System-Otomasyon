using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Site_Management_System
{
    public partial class loginPage : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        SqlConnection con= new SqlConnection(conString);
        SqlDataReader dr;
        SqlCommand com;

        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            com.Connection = con;

            com.CommandText = "Select*from security where username='"
            + usernameTXB.Text + "'and password='" + passwordTXB.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Security sec = new Security();
                sec.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("enter a correct account");
            }
            con.Close();

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();

            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            com.Connection = con;
            
            com.CommandText = "Select*from admin where username='" 
            + usernameTXB.Text + "'and password='" + passwordTXB.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                adminPage ad = new adminPage();
                ad.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("enter a correct account");
            }
            con.Close();
        }

        private void LoginMa_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.Connection = con;

            com.CommandText = "Select*from Management where username='"
            + usernameTXB.Text + "'and password='" + passwordTXB.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Management ma= new Management();
                ma.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("enter a correct account");
            }
            con.Close();


        }
    }
}
