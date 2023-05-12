using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using Image = System.Drawing.Image;
using MySqlConnector;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HotelMS
{
    public partial class AdminRc : Form
    {
        public AdminRc()
        {
            InitializeComponent();
        }

       
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully Signed Out");
            new SignIn().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new AdminRcVA().ShowDialog();
            
            
        }

        private void Receptionists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pfp_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
         " uid=root;" +
         " pwd = '' ; " +
         "database = hotel";

            string query = "SELECT Name,aProfilePic FROM Admin ";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label1.Text = reader.GetString(0).ToString();
                        byte[] imageData = (byte[])reader["aProfilePic"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pfp1.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            new AdminRcA ().ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new AdminRcD().ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            new AdminRcU().ShowDialog();
           
        }
    }
}
