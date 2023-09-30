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

namespace Site_Management_System.Forms
{
    public partial class Management_Expenses : Form
    {

        static string conString = System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        public Management_Expenses()
        {
            InitializeComponent();
        }
        public void success()
        {
            MessageBox.Show("Successful");

        }
        public void clear()
        {
            NameTXB.Clear();
            PriceTXB.Clear();

        }
        public void refresh()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "Select*from Expense_Type";
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
            string query = "Delete from Expense_Type where ID=@id";
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com=new SqlCommand(query, con);
            com.Parameters.AddWithValue("@id",id);
            com.ExecuteNonQuery();
            con.Close();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ResidantPageBTN_Click(object sender, EventArgs e)
        {
            Management ma=new Management();
            ma.Show();
            Hide();
        }

        private void LogOutBTN_Click(object sender, EventArgs e)
        {
            loginPage log=new loginPage();
            log.Show();
            Hide();
        }
        int i = 0;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            NameTXB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            PriceTXB.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
         
        }

        private void AddExpenseBTN_Click(object sender, EventArgs e)
        {
            string query = "insert into Expense_Type (name,Fee)Values(@name,@Fee)";
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand(query,con);
            com.Parameters.AddWithValue("@name",NameTXB.Text);
            com.Parameters.AddWithValue("@Fee", PriceTXB.Text);
            com.ExecuteNonQuery();
            con.Close();
            refresh();
            clear();
            success();

        }

        private void DeleteExpenseBTN_Click(object sender, EventArgs e)
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

        private void UpdateExpenseBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "Update Expense_Type set Name=@name,Fee=@fee where ID=@id";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", NameTXB.Text);
                com.Parameters.AddWithValue("@fee", PriceTXB.Text);
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

        private void Total_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "SELECT SUM (Fee) as Total FROM Expense_Type;";
                SqlCommand com= new SqlCommand(query, con);
                com.ExecuteNonQuery();
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                ss.Fill(dt);
                dataGridView1.DataSource = bs;
                con.Close();
                success();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ListExpense_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
