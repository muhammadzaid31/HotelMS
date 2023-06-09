﻿using System;
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
    public partial class CheckAvail : Form
    {
        public CheckAvail()
        {
            InitializeComponent();
        }

        private void CheckAvail_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
           " uid=root;" +
           " pwd = '' ; " +
           "database = hotel";

          

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();


            string query = "SELECT * FROM Rooms WHERE rStatus=False";


            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            ArrayList ListrID = new ArrayList();
            ArrayList ListrType = new ArrayList();
            ArrayList ListrPrice = new ArrayList();
            ArrayList ListrStatus = new ArrayList();
            while (reader.Read())
            {
                ListrID.Add(reader["rID"].ToString());
                ListrType.Add(reader["rType"].ToString());
                ListrPrice.Add(reader["rPrice"].ToString());
                ListrStatus.Add(reader["rStatus"].ToString());

            }
            oRooms.Rows.Clear();
            for (int i = 0; i < ListrID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(oRooms);
                newRow.Cells[0].Value = ListrID[i];
                newRow.Cells[1].Value = ListrType[i];
                newRow.Cells[2].Value = ListrPrice[i];
                newRow.Cells[3].Value = ListrStatus[i];
                oRooms.Rows.Add(newRow);
            }
            reader.Close();


            string query1 = "SELECT * FROM Rooms WHERE rStatus=True";
            
         
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = command1.ExecuteReader();
            ArrayList ListrID1 = new ArrayList();
            ArrayList ListrType1 = new ArrayList();
            ArrayList ListrPrice1 = new ArrayList();
            ArrayList ListrStatus1 = new ArrayList();
            while (reader1.Read())
            {
                ListrID1.Add(reader1["rID"].ToString());
                ListrType1.Add(reader1["rType"].ToString());
                ListrPrice1.Add(reader1["rPrice"].ToString());
                ListrStatus1.Add(reader1["rStatus"].ToString());

            }
            vRooms.Rows.Clear();
            for (int i = 0; i < ListrID1.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(vRooms);
                newRow.Cells[0].Value = ListrID1[i];
                newRow.Cells[1].Value = ListrType1[i];
                newRow.Cells[2].Value = ListrPrice1[i];
                newRow.Cells[3].Value = ListrStatus1[i];
                vRooms.Rows.Add(newRow);
            }
            reader1.Close();
            conn.Close();
        }

        private void oRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (oRooms.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)oRooms.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string tagValue = buttonCell.Value.ToString();
                CheckOut myForm = new CheckOut();
                myForm.TagValue = tagValue;
                this.Hide();
                myForm.ShowDialog();
                this.Show();
            }

        }

        private void vRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vRooms.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell1 = (DataGridViewButtonCell)vRooms.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string tagValue = buttonCell1.Value.ToString();
                CheckIn myForm = new CheckIn();
                myForm.TagValue = tagValue;
                this.Hide();
                myForm.ShowDialog();
                this.Show();
            }
        }
    }
}
