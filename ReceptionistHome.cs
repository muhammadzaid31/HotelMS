using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelMS
{
    public partial class ReceptionistHome : Form
    {
        public ReceptionistHome()
        {
            InitializeComponent();
        }

        private int uid;
        public int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void ReceptionistHome_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
     " uid=root;" +
     " pwd = '' ; " +
     "database = hotel";

            string query = "SELECT rcID, Name,rcProfilePic FROM receptionists Where ID=@ID ";
            MySqlConnection conn = new MySqlConnection(connString);
            int uid = this.UID;
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", uid);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label1.Text = reader.GetString(1);
                byte[] imageData = (byte[])reader["rcProfilePic"];
                MemoryStream ms = new MemoryStream(imageData);
                pfp1.Image = Image.FromStream(ms);
                conn.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Succesfully Signed Out");
            new SignIn().ShowDialog();
            this.Close();

        }

        private void btnGuestProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateGuest().ShowDialog();
            this.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerBKVa().ShowDialog();
            this.Show(); 
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckAvail().ShowDialog();
            this.Show();
        }
    }
}
