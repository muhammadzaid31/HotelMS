using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using MySqlConnector;
using Org.BouncyCastle.Asn1.X509;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HotelMS
{
    public partial class AdminRcVA : Form
    {
        public AdminRcVA()
        {
            InitializeComponent();
        }

        private void Receptionists_Layout(object sender, LayoutEventArgs e)
        {
            
        }
        private void Receptionists_Load(object sender, LayoutEventArgs e)
        {

            
        }

        private void AdminRcVA_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
           " uid=root;" +
           " pwd = '' ; " +
           "database = hotel";

            string query = "SELECT rcID, Name, DoB, Gender, Phone, Email,ID FROM Receptionists";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            ArrayList ListrcID = new ArrayList();
            ArrayList ListName = new ArrayList();
            ArrayList ListDoB = new ArrayList();
            ArrayList ListGender = new ArrayList();
            ArrayList ListPhone = new ArrayList();
            ArrayList ListEmail = new ArrayList();
            ArrayList ListID = new ArrayList();
            
            while (reader.Read())
            {
                ListrcID.Add(reader["rcID"].ToString());
                ListName.Add(reader["Name"].ToString());
                ListDoB.Add(reader["DoB"].ToString());
                ListGender.Add(reader["Gender"].ToString());
                ListPhone.Add(reader["Phone"].ToString());
                ListEmail.Add(reader["Email"].ToString());
                ListID.Add(reader["ID"].ToString());
                
            }
            Receptionists.Rows.Clear();
            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Receptionists);
                newRow.Cells[0].Value = ListrcID[i];
                newRow.Cells[1].Value = ListName[i];
                newRow.Cells[2].Value = ListDoB[i];
                newRow.Cells[3].Value = ListGender[i];
                newRow.Cells[4].Value = ListPhone[i];
                newRow.Cells[5].Value = ListEmail[i];
                newRow.Cells[6].Value = ListID[i];
                Receptionists.Rows.Add(newRow);
            }
            reader.Close();
            conn.Close();
        }


        private void Receptionists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Receptionists.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)Receptionists.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string tagValue = buttonCell.Value.ToString();
                AdminRcVp myForm = new AdminRcVp();
                myForm.TagValue = tagValue;
                myForm.ShowDialog();
            }
        }
    }
}
