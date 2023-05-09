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
using static System.Net.WebRequestMethods;

namespace HotelMS
{
    public partial class ManagerBKU : Form
    {
        public ManagerBKU()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bID = txtuserID.Text;
            string connString = "server = localhost ;" +
      " uid=root;" +
      " pwd = '' ; " +
      "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query = "select * from bill where bID = @bID";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@bID", bID);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            txtbID.Text = reader["bID"].ToString();
            DateTime selectedDate = dtp1.Value; ;
            string bDate = selectedDate.ToString("dd-MM-yy");
            txtBill.Text = reader["bAmount"].ToString();
            txtFine.Text = reader["bFine"].ToString();
            txtTotal.Text = reader["totalAmount"].ToString();
            txtbkID.Text = reader["bkID"].ToString();
            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
     " uid=root;" +
     " pwd = '' ; " +
     "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string ubID = txtuserID.Text.ToString();
            
            string query = "UPDATE bill set bID=@bID,bDate=@bDate,bAmount=@bAmount,bFine=@bFine,totalAmount=@bTotal,bkID=@bkID " +
                "WHERE bID=@ubiD";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@bID", txtbID.Text.ToString());
            command.Parameters.AddWithValue("@ubID", ubID);
            command.Parameters.AddWithValue("@bDate", dtp1.Value.ToString("dd-MM-yy"));
            command.Parameters.AddWithValue("@bAmount", txtBill.Text.ToString());
            command.Parameters.AddWithValue("@bFine", txtFine.Text.ToString());
            command.Parameters.AddWithValue("@bTotal", txtTotal.Text.ToString());
            command.Parameters.AddWithValue("@bkID", txtbkID.Text.ToString());
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Room Updated Successfully");
            this.Close();
        }
    }
}
