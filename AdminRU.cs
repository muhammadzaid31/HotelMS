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
    public partial class AdminRU : Form
    {
        public AdminRU()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rID = txtruID.Text;
            string connString = "server = localhost ;" +
      " uid=root;" +
      " pwd = '' ; " +
      "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query = "select * from rooms where rID = @rID";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@rID", rID);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            txtrID.Text=reader["rID"].ToString();
            cB1.Text= reader["rType"].ToString();
            txtrPrice.Text= reader["rPrice"].ToString();
            txtrStatus.Text= reader["rStatus"].ToString();
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
            string rID = txtrID.Text.ToString();
            /*string rType = cB1.Text.ToString();
            int rPrice = int.Parse(txtrPrice.Text.ToString());
            bool rStatus = bool.Parse(txtrStatus.Text.ToString());*/

        

            string query = "UPDATE rooms set rID=@RuID,rType=@rType,rPrice=@rPrice,rStatus=@rStatus " +
                "WHERE rID=@riD";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@riD", txtruID.Text.ToString());
            command.Parameters.AddWithValue("@RuID", txtrID.Text.ToString());
            command.Parameters.AddWithValue("@rType", cB1.Text.ToString());
            command.Parameters.AddWithValue("@rPrice", txtrPrice.Text.ToString());
            command.Parameters.AddWithValue("@rStatus", txtrStatus.Text.ToString());
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Room Updated Successfully");
            this.Close();
        }
    }
}
