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
    public partial class ManagerGVp : Form
    {
        public ManagerGVp()
        {
            InitializeComponent();
        }

        private string tagValue;
        public string TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }
        private void ManagerGVp_Load(object sender, EventArgs e)
        {
            string tagValue = this.TagValue;
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";

            string query = "SELECT * FROM guest WHERE gID = @id";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", tagValue);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                gID.Text = reader.GetString(0).ToString();
                name.Text = reader.GetString(1).ToString();
                DoB.Text = reader.GetString(2).ToString();
                Gender.Text = reader.GetString(3).ToString();
                Phone.Text = reader.GetString(4).ToString();
                Email.Text = reader.GetString(5).ToString();
                byte[] imageData = (byte[])reader["gProfilePic"];
                MemoryStream ms = new MemoryStream(imageData);
                pfp.Image = Image.FromStream(ms);
                conn.Close();

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ManagerGBk myForm = new ManagerGBk();
            myForm.GID = gID.Text;
            myForm.ShowDialog();
        }
    }
}
