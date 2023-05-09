using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        private string tagValue;
        public string TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }
        
        private void CheckOut_Load(object sender, EventArgs e)
        {

            label10.Hide();
            label3.Hide();
            label2.Hide();
            label1.Hide();
            label8.Hide();
            label4.Hide();
            label9.Hide();
            label7.Hide();
            label5.Hide();
            txtbID.Hide();
            txtbD.Hide();
            txtbA.Hide() ;
            txtFine.Hide();
            txtTotal.Hide();
            txtkID.Hide();
            txtRprice.Hide();
            txtDuration.Hide();
            txtCODate.Hide();
            label12.Hide();

            string tagValue = this.TagValue;
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn= new MySqlConnection(connString);
            string query = "UPDATE rooms set rStatus=False WHERE rID=@rID";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@rID",tagValue);
            command.ExecuteNonQuery();
            conn.Close();

            MySqlConnection conn1 = new MySqlConnection(connString);
            string query1 = "Select rPrice from rooms WHERE rID=@rID";
           
            conn1.Open();
            MySqlCommand command1 = new MySqlCommand(query1, conn1);
            command1.Parameters.AddWithValue("@rID", tagValue);
            MySqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {

                txtRprice.Text = reader.GetString(0).ToString() ;
            }
            reader.Close();
            conn1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Show();
            label3.Show();
            label2.Show();
            label1.Show();
            label8.Show();
            label4.Show();
            label9.Show();
            label7.Show();
            label5.Show();
            txtbID.Show();
            txtbD.Show();
            txtbA.Show();
            txtFine.Show();
            txtTotal.Show();
            txtkID.Show();
            txtCODate.Show();
            label12.Show();

            string gID = txtgID.Text.ToString();
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn2 = new MySqlConnection(connString);
            string query2 = "Select bkID,bkDate,checkOutDate,bkDuration from bookingdetails WHERE rID=@roID and gID=@gID";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(query2, conn2);
            command2.Parameters.AddWithValue("@roID", tagValue);
            command2.Parameters.AddWithValue("@gID", gID);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {

                txtkID.Text = reader2.GetString(0).ToString();
                txtbD.Text = reader2.GetString(1).ToString();
                txtCODate.Text = reader2.GetString(2).ToString();
                txtDuration.Text= reader2.GetString(3).ToString();  
            }
            reader2.Close();
            conn2.Close();

            string currentDate = DateTime.Now.ToString("dd-MM-yy");
            DateTime startDate = DateTime.ParseExact(txtCODate.Text, "dd-MM-yy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(currentDate, "dd-MM-yy", CultureInfo.InvariantCulture);

            TimeSpan duration = endDate - startDate;
            int numDays = duration.Days;
            int fine;
            if (numDays > 0)
            {
                fine = numDays * int.Parse(txtRprice.Text);
                txtFine.Text = fine.ToString(); 

            }
            int price = int.Parse(txtRprice.Text) * int.Parse(txtDuration.Text);
            txtbA.Text = price.ToString();

            /*
            MySqlConnection conn3 = new MySqlConnection(connString);
            string query3 = "";

            conn3.Open();
            MySqlCommand command3 = new MySqlCommand(query3, conn3);
            command2.Parameters.AddWithValue("@rID", tagValue);
            MySqlDataReader reader3 = command2.ExecuteReader();
            conn3.Close()*/
        }
    }
}
