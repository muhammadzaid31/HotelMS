using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HotelMS
{
    public partial class AdminRc : Form
    {
        public AdminRc()
        {
            InitializeComponent();
        }

       /* private void Receptionists_Load(object sender, EventArgs e) 
        {
            try
            {
                string connString = "server = localhost ;" +
               " uid=root;" +
               " pwd = '' ; " +
               "database = hotel";
               
                string query = "SELECT * FROM Receptionists";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Receptionists.Rows.Add(reader.GetString(0), reader.GetString(1), 
                                           reader.GetString(2), reader.GetString(3), 
                                           reader.GetString(4), reader.GetString(5), reader.GetString(6));
                }                
                conn.Close();
            }
            catch (Exception ex)
            {
                
            }
        }*/
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
            this.Hide();
            new AdminRcVA().ShowDialog();
            this.Close();
        }

        private void Receptionists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
