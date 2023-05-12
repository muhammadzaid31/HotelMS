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
using MySqlConnector;

namespace HotelMS
{
    public partial class AdminMD : Form
    {
        public AdminMD()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                string mID = txtMid.Text;
                string connString = "server = localhost ;" +
             " uid=root;" +
             " pwd = '' ; " +
             "database = hotel";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                string query1 = "Select ID from Managers Where mID = @mID";
                MySqlCommand command1 = new MySqlCommand(query1, conn);
                command1.Parameters.AddWithValue("@mID", mID);
                MySqlDataReader reader1 = command1.ExecuteReader();
                reader1.Read();
                string id = reader1.GetString(0).ToString();
                string query2 = "DELETE FROM users WHERE ID = @ID;";
            reader1.Close();
            MySqlCommand command2 = new MySqlCommand(query2, conn);
                command2.Parameters.AddWithValue("@ID", id);
                command2.ExecuteNonQuery();
                
                string query = "DELETE FROM managers WHERE mID = @mID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@mID", mID);
                command.ExecuteNonQuery();
                MessageBox.Show("Manager Account Succesfully Deleted");
                this.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Manager Account Succesfully Deleted");
                this.Close();
            }
        }
    }
}
