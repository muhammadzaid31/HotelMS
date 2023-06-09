﻿using Org.BouncyCastle.Asn1.Pkcs;
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
using System.Xml.Linq;
//using MySql.Data.MySqlClient;
using MySqlConnector;
using Image = System.Drawing.Image;

namespace HotelMS
{
    public partial class AdminR : Form
    {
        public AdminR()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminR_Load(object sender, EventArgs e)
        {
            
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";

            string query = "SELECT * FROM Admin ";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label2.Text = reader["Name"].ToString();
                byte[] imageData = (byte[])reader["aProfilePic"];
                MemoryStream ms = new MemoryStream(imageData);
                pfp.Image = Image.FromStream(ms);
                conn.Close();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new AdminRD().ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            new AdminRU().ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
            new AdminRVa().ShowDialog();
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new AdminRA().ShowDialog();
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }
    }
}
