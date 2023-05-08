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
    public partial class AdminRD : Form
    {
        public AdminRD()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                string rID = txtRid.Text;
                string connString = "server = localhost ;" +
             " uid=root;" +
             " pwd = '' ; " +
             "database = hotel";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();


                string query = "DELETE FROM rooms WHERE rID = @rID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@rID", rID);
                command.ExecuteNonQuery();
                MessageBox.Show("Room Succesfully Deleted");
                this.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Room Account Succesfully Deleted");
                this.Close();
            }
        }
    }
}
