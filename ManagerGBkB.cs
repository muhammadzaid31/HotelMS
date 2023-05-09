using Org.BouncyCastle.Asn1.Pkcs;
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
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace HotelMS
{
    public partial class ManagerGBkB : Form
    {
        public ManagerGBkB()
        {
            InitializeComponent();
        }

        private string tagValue;
        public string TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }

        private void ManagerGBkB_Load(object sender, EventArgs e)
        {
            string bkID = this.TagValue;
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";

            string query = "SELECT * FROM bill WHERE bID = @id";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", tagValue);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtbID.Text = reader.GetString(0).ToString();
                txtbD.Text = reader.GetString(1).ToString();
                txtbA.Text = reader.GetString(2).ToString();
                txtFine.Text= reader.GetString(3).ToString();
                txtTotal.Text= reader.GetString(4).ToString();
                txtkID.Text = reader["bkID"].ToString();
                conn.Close();

            }
        }
    }
}
