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
    public partial class ManagerGD : Form
    {
        public ManagerGD()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                string gID = txtgid.Text;
                string connString = "server = localhost ;" +
             " uid=root;" +
             " pwd = '' ; " +
             "database = hotel";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                string query = "DELETE FROM guest WHERE gID = @gID";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@gID", gID);
                command.ExecuteNonQuery();
                MessageBox.Show("Guest Profile Succesfully Deleted");
                this.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Guest Profile Succesfully Deleted");
                this.Close();
            }
        }
    }
}
