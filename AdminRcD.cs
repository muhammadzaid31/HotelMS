﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.WebRequestMethods;
using static LinqToDB.Reflection.Methods.LinqToDB;
using static LinqToDB.Sql;
//using MySqlConnector;

namespace HotelMS
{
    public partial class AdminRcD : Form
    {
        public AdminRcD()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            string rcID = txtRcid.Text;
            string connString = "server = localhost ;" +
         " uid=root;" +
         " pwd = '' ; " +
         "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query1 = "Select ID from Receptionists Where rcID = @rcID";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@rcID", rcID);
            MySqlDataReader reader = command1.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader.GetString(0));
            reader.Close();
            string query2 = "DELETE FROM users WHERE ID = @ID;";
            MySqlCommand command2 = new MySqlCommand(query2, conn);
            command2.Parameters.AddWithValue("@ID", id);
            command2.ExecuteNonQuery();
            string query = "DELETE FROM Receptionists WHERE rcID = @rcID";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@rcID", rcID);
            command.ExecuteNonQuery();
            MessageBox.Show("Receptionist Account Succesfully Deleted");
            this.Close();
            conn.Close();
        }
     
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRcid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
