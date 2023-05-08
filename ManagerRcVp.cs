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
    public partial class ManagerRcVp : Form
    {
        public ManagerRcVp()
        {
            InitializeComponent();
        }
        private string tagValue;
        public string TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }

        private void ManagerRcVp_Load(object sender, EventArgs e)
        {
            string tagValue = this.TagValue;
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";

            string query = "SELECT * FROM Receptionists WHERE rcID = @id";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", tagValue);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                rcID.Text = reader.GetString(0).ToString();
                name.Text = reader.GetString(1).ToString();
                DoB.Text = reader.GetString(2).ToString();
                Gender.Text = reader.GetString(3).ToString();
                Phone.Text = reader.GetString(4).ToString();
                Email.Text = reader.GetString(5).ToString();
                ID.Text = reader.GetInt32(6).ToString();
                byte[] imageData = (byte[])reader["rcProfilePic"];
                MemoryStream ms = new MemoryStream(imageData);
                pfp.Image = Image.FromStream(ms);
                conn.Close();

            }
        }
    }
}
