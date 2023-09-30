using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Management_System
{

    
    public partial class Management : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);

        public void success()
        {
            MessageBox.Show("Successful");

        }

        public void clear()
        {
            NameTXB.Clear();
            SurnameTXB.Clear();
            AptNoTXB.Clear();
            BlockTXB.Clear();
            Phone1TXB.Clear();
            Phone2TXB.Clear();
            SearchTXB.Clear();
        
        }


        public void refresh()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "Select*from Residant";
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

        public void delete(int id)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "Delete from Residant where ID=@id";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception)
            {

                throw;
            }
           


        }
        public Management()
        {
            InitializeComponent();
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "insert into Residant(Name,Surname,Apt_no,Block_name,Phone_1,Phone_2,Dues_payment) values(@name,@surname,@aptno,@blockname,@phone1,@phone2,'Not Paid')";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", NameTXB.Text);
                com.Parameters.AddWithValue("@surname", SurnameTXB.Text);
                com.Parameters.AddWithValue("@aptno", AptNoTXB.Text);
                com.Parameters.AddWithValue("@blockname", BlockTXB.Text);
                com.Parameters.AddWithValue("@phone1", Phone1TXB.Text);
                com.Parameters.AddWithValue("@phone2", Phone2TXB.Text);
                com.ExecuteNonQuery();
                con.Close();
                refresh();
                clear();
                success();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                delete(id);
                refresh();
                clear();
                success();

            }



        }
        int i = 0;
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "Update Residant Set name=@name,Surname=@surname,Apt_no=@aptno,Block_name=@block,Phone_1=@phone1,Phone_2=@phone2 where ID=@id";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", NameTXB.Text);
                com.Parameters.AddWithValue("@surname", SurnameTXB.Text);
                com.Parameters.AddWithValue("@aptno", int.Parse(AptNoTXB.Text));
                com.Parameters.AddWithValue("@block", BlockTXB.Text);
                com.Parameters.AddWithValue("@phone1", Phone1TXB.Text);
                com.Parameters.AddWithValue("@phone2", Phone2TXB.Text);
                com.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                com.ExecuteNonQuery();
                con.Close();
                refresh();
                clear();
                success();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i= e.RowIndex;
            NameTXB.Text=dataGridView1.Rows[i].Cells[1].Value.ToString();
            SurnameTXB.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            AptNoTXB.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            BlockTXB.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            Phone1TXB.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            Phone2TXB.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void LogOutBTN_Click(object sender, EventArgs e)
        {
            loginPage log = new loginPage();
            log.Show();
            Hide();
            
        }

        private void ExpensesPageBTN_Click(object sender, EventArgs e)
        {
           Forms.Management_Expenses ma= new Forms.Management_Expenses();
            ma.Show();
            Hide();

        }

        private void MarkAsPaidBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " update Residant set Dues_payment='Paid'where ID=@id ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                com.ExecuteNonQuery();
                con.Close();
                refresh();
                clear();
                success();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void MarkAsUnPaidBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " update Residant set Dues_payment='Not Paid'where ID=@id ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                com.ExecuteNonQuery();
                con.Close();
                refresh();
                clear();
                success();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void MarkAsUnpaidAllBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " update Residant set Dues_payment='Not Paid'";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                refresh();
                clear();
                success();

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Residant where Name=@name";
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(query,con);
                com.Parameters.AddWithValue("@name",SearchTXB.Text);
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                ss.Fill(dt);
                dataGridView1.DataSource = bs;
                clear();
                con.Close();
                success();
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
