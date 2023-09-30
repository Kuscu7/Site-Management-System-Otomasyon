using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.VisualBasic;

namespace Site_Management_System
{

    
    public partial class Security : Form    //new
    {

        public void form_refresh()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "SELECT Guests.ID, concat(Guests.Name, Guests.Surname)as Guest_Name ,Guests.Entry_Time,concat(Residant.Name, Residant.Surname)as Residant_Name, Residant.Block_name, Residant.Apt_no " +
                    "FROM  Guests " +
                    "INNER JOIN  Residant  ON Guests.Residant_ID=Residant.ID ";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                ss.Fill(dt);
                dataGridView1.DataSource = bs;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }




        static string conString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);


        public void DeleteGuest(int id)
        {
            try
            {
                
                 string dlt = "delete From Guests where ID=@id";
                 if (con.State == ConnectionState.Closed)
                 {
                     con.Open();
                 }
                 SqlCommand com = new SqlCommand(dlt, con);
                 com.Parameters.AddWithValue("@id", id);
                 com.ExecuteNonQuery();
                 con.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void ListAllGuest()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "select Guests.ID,  concat(Guests.Name,Guests.Surname) as Name_Surname, Guests.Entry_Time, CONCAT(Residant.Name,Residant.Surname)as Residant_Name_Surname,Residant.Block_name, Residant.Apt_no, Residant.Phone_1,Residant.Phone_2 from Guests inner join Residant on Guests.Residant_ID=Residant.ID";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                
                bs.DataSource = dt;
                ss.Fill(dt);
                dataGridView1.DataSource = bs;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public void addGuest(int id)
        {
            try
            {
                string query = "insert into Guests(Name,Surname,Entry_Time,Residant_ID) values (@name,@surname,GETDATE(),@id)";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name",textBox1.Text);
                com.Parameters.AddWithValue("@surname", textBox2.Text);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void list() //new
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "select Residant.ID, concat(Residant.Name,' ',Residant.Surname)as Name_Surname ,Residant.Apt_no,Residant.Block_name,Residant.Phone_1,Residant.Phone_2 " +
                    "from Residant " +
                    "where name =@name;";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                com.Parameters.AddWithValue("@name", listTXB.Text);
                bs.DataSource = dt;
                ss.Fill(dt);
                dataGridView1.DataSource = bs;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
                
            }
            
        public Security()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                        
        }

        private void Security_Load(object sender, EventArgs e) //new
        {
            form_refresh();
            


        }

        private void button2_Click(object sender, EventArgs e)//new
        {
            loginPage log=new loginPage();
            log.Show();
            Hide();

        }

        private void listBTN_Click(object sender, EventArgs e)//new
        {

            list();


        }

        private void GuestBTN_Click(object sender, EventArgs e)
        {
            

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                addGuest(id);
                form_refresh();

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listGuestBTN_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "SELECT Guests.ID, concat(Guests.Name, Guests.Surname)as Guest_Name ,Guests.Entry_Time,concat(Residant.Name, Residant.Surname)as Residant_Name, Residant.Block_name, Residant.Apt_no,Residant.Phone_1,Residant.Phone_2 " +
                    "FROM  Guests " +
                    "INNER JOIN  Residant  ON Guests.Residant_ID=Residant.ID where Guests.name=@name;";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                com.Parameters.AddWithValue("@name", ListGuestTXB.Text);
                bs.DataSource = dt;
                ss.Fill(dt);
                dataGridView1.DataSource = bs;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                DeleteGuest(id);
                form_refresh();


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListAllGuest();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
