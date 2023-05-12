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
using LinqToDB.Mapping;
using MySql.Data.MySqlClient;

namespace HotelMS
{
    public partial class AdminM : Form
    {
       
        public AdminM()
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
            
            new AdminMVa().ShowDialog();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new AdminMA().ShowDialog();
                       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new AdminMD().ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AdminMU().ShowDialog();          
        }

        private void AdminM_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
       " uid=root;" +
       " pwd = '' ; " +
       "database = hotel";

            string query = "SELECT Name,aProfilePic FROM Admin ";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label1.Text = reader.GetString(0).ToString();
                byte[] imageData = (byte[])reader["aProfilePic"];
                MemoryStream ms = new MemoryStream(imageData);
                pfp1.Image = Image.FromStream(ms);
                conn.Close();
            }
        }
    }
}
