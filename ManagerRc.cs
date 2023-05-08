using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelMS
{
    public partial class ManagerRc : Form
    {
        public ManagerRc()
        {
            InitializeComponent();
        }
        private int uid;
        public int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void ManagerRc_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
      " uid=root;" +
      " pwd = '' ; " +
      "database = hotel";

            string query = "SELECT Name,mProfilePic FROM Managers Where ID=@ID ";
            MySqlConnection conn = new MySqlConnection(connString);
            int uid = this.UID;
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", uid);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label1.Text = reader.GetString(0).ToString();
                byte[] imageData = (byte[])reader["mProfilePic"];
                MemoryStream ms = new MemoryStream(imageData);
                pfp1.Image = Image.FromStream(ms);
                conn.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome myForm=new ManagerHome();
            myForm.UID = this.UID;
            myForm.ShowDialog();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully Signed Out");
            new SignIn().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerRcVa().ShowDialog();
            this.Close();
        }
    }
}
