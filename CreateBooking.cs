using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HotelMS
{
    public partial class CreateBooking : Form
    {
        public CreateBooking()
        {
            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {
            managerID.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string RID = txtrID.Text;
            string recID = txtrcID.Text;
            string bookingID = txtbkID.Text;
            string billID = txtBID.Text;
            DateTime selectedDate = dtp.Value;
            string CheckOutDate = selectedDate.ToString("dd-MM-yy");
            string current = DateTime.Now.ToString("dd-MM-yy");
            DateTime startDate = DateTime.ParseExact(current, "dd-MM-yy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(CheckOutDate, "dd-MM-yy", CultureInfo.InvariantCulture);

            TimeSpan num = endDate - startDate;
            int numDays = num.Days;
            string duration = numDays.ToString();
            string[] m1 = { "RC01", "RC02", "RC03" };
            string[] m2 = { "RC04", "RC05", "RC06" };
                       

            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE rooms SET rStatus = False WHERE rID = @rID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@rID", txtrID.Text);
                    command.ExecuteNonQuery();
                }
            }
            if (m1.Contains(recID))
            {
                managerID.Text = "M01";
            }
            else if (m2.Contains(recID))
            {
                managerID.Text = "M02";
            }
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query2 = "INSERT INTO bookingdetails(bkID,bkDate,checkOutDate,bkDuration,rID,rcID,mID,gID,bID) " +
                    "VALUES (@bkID,@bkDate,@CODate,@duration,@rID,@rcID,@mID,@gID,@bID)";
                using (MySqlCommand command = new MySqlCommand(query2, conn))
                {
                 
                    command.Parameters.AddWithValue("@bkID", bookingID);
                    command.Parameters.AddWithValue("@bkDate", current);
                    command.Parameters.AddWithValue("@CODate", CheckOutDate);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@rID", RID);
                    command.Parameters.AddWithValue("@rcID", recID);
                    command.Parameters.AddWithValue("@mID", managerID.Text );
                    command.Parameters.AddWithValue("@gID", txtgID.Text);
                    command.Parameters.AddWithValue("@bID", billID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully created");
                    this.Close();
                }
            }
        }
    }
}

