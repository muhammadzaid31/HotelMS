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
            label13.Hide();

            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand("UPDATE rooms SET rStatus = True WHERE rID = @rID", conn))
                {
                    command.Parameters.AddWithValue("@rID", TagValue);
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand("SELECT rPrice FROM rooms WHERE rID = @rID", conn))
                {
                    command.Parameters.AddWithValue("@rID", TagValue);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtRprice.Text = reader.GetString(0);
                        }
                    }
                }
            }
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
            string connString = "server=localhost;uid=root;pwd='';database=hotel";
            string query = "SELECT bkID,checkOutDate, bkDuration FROM bookingdetails WHERE rID = @roID AND gID = @gID";

            using (var connection = new MySqlConnection(connString))
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roID", tagValue);
                    command.Parameters.AddWithValue("@gID", gID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtkID.Text = reader.GetString(0);
                            txtbD.Text = DateTime.Now.ToString("dd-MM-yy");
                            label12.Text = reader.GetString(1);
                            txtDuration.Text = reader.GetString(2);
                        }
                    }
                }
            }
      
            DateTime startDate = DateTime.ParseExact(label12.Text, "dd-MM-yy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(txtbD.Text, "dd-MM-yy", CultureInfo.InvariantCulture);

            TimeSpan duration = endDate - startDate;
            int numDays = duration.Days;
            int fine;
            int price = int.Parse(txtRprice.Text) * int.Parse(txtDuration.Text);
            txtFine.Text = price.ToString();
            if (numDays > 0)
            {
                fine = numDays * int.Parse(txtRprice.Text);
                txtFine.Text = fine.ToString();
                txtbA.Text = price.ToString();
                txtTotal.Text=(int.Parse(txtFine.Text)+int.Parse(txtbA.Text)).ToString();
            }
            else 
            {
                
                txtFine.Text="0";
                txtbA.Text= price.ToString();
                txtTotal.Text = txtbA.Text; 
                
            }
            txtbID.Text = textBox1.Text;
            
            MySqlConnection conn3 = new MySqlConnection(connString);
            string query3 = "INSERT INTO bill(bID, bDate, bAmount, bFine, totalAmount, bkID) " +
                "VALUES (@bID,@bDate,@bAmount,@bFine,@totalAmount,@bkID)";

            conn3.Open();
            MySqlCommand command3 = new MySqlCommand(query3, conn3);
            command3.Parameters.AddWithValue("@bID", textBox1.Text);
            command3.Parameters.AddWithValue("@bDate", label13.Text );  
            command3.Parameters.AddWithValue("@bAmount", txtFine.Text);
            command3.Parameters.AddWithValue("@bFine", txtFine.Text);
            command3.Parameters.AddWithValue("@totalAmount", txtTotal.Text);
            command3.Parameters.AddWithValue("@bkID",txtkID.Text );
            command3.ExecuteNonQuery();
            conn3.Close();
            MessageBox.Show("Successfully Checked Out");
        }
    }
}
