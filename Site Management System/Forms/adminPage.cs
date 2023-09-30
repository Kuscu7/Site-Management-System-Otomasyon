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
    public partial class adminPage : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        SqlCommand com;
       

        public void refresh()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "Select*from Apartman_Site";
                SqlDataAdapter ss = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                BindingSource bsourse = new BindingSource();
                bsourse.DataSource = dt;
                ss.Fill(dt);
                ApartmanDGV.DataSource = bsourse;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void delete(int id)//new
        {
            try
            {
                string dlt = "delete From Apartman_Site where ID=@id";
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



        public adminPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void adminPage_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {

            
            loginPage log = new loginPage();
            log.Show();
            Hide();

        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(CapacityTXB.Text);
                com = new SqlCommand();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                com.Connection = con;

                com.CommandText = "Insert into Apartman_Site(Name,Capacity) values (@name,@capacity)";
                com.Parameters.AddWithValue("@name", NameTXB.Text);
                com.Parameters.AddWithValue("@capacity", a);

                com.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            refresh();


        }

        private void CapacityTXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApartmanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow ap = this.ApartmanDGV.Rows[e.RowIndex];
                
                NameTXB.Text =ap.Cells["name"].Value.ToString();
                CapacityTXB.Text =ap.Cells["capacity"].Value.ToString();
            }
            
        }
        

        private void DeleteBTN_Click(object sender, EventArgs e) //new
        {
            foreach (DataGridViewRow drow in ApartmanDGV.SelectedRows)
            {
                int id=Convert.ToInt32(drow.Cells[0].Value);
                delete(id);
                refresh();
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e) //new
        {

            try
            {
                string update = "update apartman_site set Name=@name,capacity=@capa where id=@id";

                SqlCommand com = new SqlCommand(update, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                com.Parameters.AddWithValue("@name", NameTXB.Text);
                com.Parameters.AddWithValue("@capa", CapacityTXB.Text);
                com.Parameters.AddWithValue("@id", ApartmanDGV.Rows[i].Cells[0].Value);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
            refresh();
        }

        int i = 0;
        private void ApartmanDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //new
        {
            i = e.RowIndex;
            NameTXB.Text= ApartmanDGV.Rows[i].Cells[1].Value.ToString();
            CapacityTXB.Text = ApartmanDGV.Rows[i].Cells[2].Value.ToString();
        }
    }
}
