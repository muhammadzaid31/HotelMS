using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Image = System.Drawing.Image;

namespace HotelMS
{
    public partial class AdminRcVp : Form
    {
        public AdminRcVp()
        {
            InitializeComponent();
        }

        private string tagValue;
        public string TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }

        private void AdminRcVp_Load(object sender, EventArgs e)
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