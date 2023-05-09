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

namespace HotelMS
{
    public partial class ManagerRcD : Form
    {
        public ManagerRcD()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                string rcID = txtRcid.Text;
                string connString = "server = localhost ;" +
             " uid=root;" +
             " pwd = '' ; " +
             "database = hotel";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                string query1 = "Select ID from Receptionists Where rcID = @rcID";
                MySqlCommand command1 = new MySqlCommand(query1, conn);
                command1.Parameters.AddWithValue("@rcID", rcID);
                MySqlDataReader reader = command1.ExecuteReader();
                reader.Read();
                string id = reader.GetString(0).ToString();
                reader.Close();
                string query2 = "DELETE FROM users WHERE ID = @ID;";
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                command2.Parameters.AddWithValue("@ID", id);
                command2.ExecuteNonQuery();
                string query = "DELETE FROM Receptionists WHERE rcID = @rcID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@rcID", rcID);
                command.ExecuteNonQuery();
                MessageBox.Show("Receptionist Account Succesfully Deleted");
                this.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Receptionist Account Succesfully Deleted");
                this.Close();
            }
        }
    }
}
