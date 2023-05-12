using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelMS
{
    public partial class ManagerGVa : Form
    {
        public ManagerGVa()
        {
            InitializeComponent();
        }

        private void ManagerGVa_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
         " uid=root;" +
         " pwd = '' ; " +
         "database = hotel";

            string query = "SELECT gID, Name, DoB, Gender, Phone, Email FROM Guest";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            ArrayList ListgID = new ArrayList();
            ArrayList ListName = new ArrayList();
            ArrayList ListDoB = new ArrayList();
            ArrayList ListGender = new ArrayList();
            ArrayList ListPhone = new ArrayList();
            ArrayList ListEmail = new ArrayList();
          

            while (reader.Read())
            {
                ListgID.Add(reader["gID"].ToString());
                ListName.Add(reader["Name"].ToString());
                ListDoB.Add(reader["DoB"].ToString());
                ListGender.Add(reader["Gender"].ToString());
                ListPhone.Add(reader["Phone"].ToString());
                ListEmail.Add(reader["Email"].ToString());
              

            }
            Guests.Rows.Clear();
            for (int i = 0; i < ListgID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Guests);
                newRow.Cells[0].Value = ListgID[i];
                newRow.Cells[1].Value = ListName[i];
                newRow.Cells[2].Value = ListDoB[i];
                newRow.Cells[3].Value = ListGender[i];
                newRow.Cells[4].Value = ListPhone[i];
                newRow.Cells[5].Value = ListEmail[i];
                Guests.Rows.Add(newRow);
            }
            reader.Close();
            conn.Close();
        }

        private void Guests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Guests.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)Guests.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string tagValue = buttonCell.Value.ToString();
                    ManagerGVp myForm = new ManagerGVp();
                    myForm.TagValue = tagValue;
                    myForm.ShowDialog();
                }
            }
            catch (Exception ex) 
            {

            }
        }
    }
}
