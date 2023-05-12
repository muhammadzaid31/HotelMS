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
    public partial class ManagerGBk : Form
    {
        public ManagerGBk()
        {
            InitializeComponent();
        }
        private string gID;
        public string GID
        {
            get { return gID; }
            set { gID = value; }
        }
        private void ManagerGBk_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
        " uid=root;" +
        " pwd = '' ; " +
        "database = hotel";

            string query = "SELECT bkID, bkDate, bkDuration, rID, bID, rcID FROM bookingdetails where gID=@gID";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            string gID = this.GID;
            command.Parameters.AddWithValue("@gID",gID);
            MySqlDataReader reader = command.ExecuteReader();
            ArrayList ListbkID = new ArrayList();
            ArrayList ListbkDate = new ArrayList();
            ArrayList ListbkDuration = new ArrayList();
            ArrayList ListrID = new ArrayList();
            ArrayList ListbID = new ArrayList();
            ArrayList ListrcID = new ArrayList();

            while (reader.Read())
            {
                ListbkID.Add(reader["bkID"].ToString());
                ListbkDate.Add(reader["bkDate"].ToString());
                ListbkDuration.Add(reader["bkDuration"].ToString());
                ListrID.Add(reader["rID"].ToString());
                ListbID.Add(reader["bID"].ToString());
                ListrcID.Add(reader["rcID"].ToString());


            }
            bkHistory.Rows.Clear();
            for (int i = 0; i < ListbkID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bkHistory);
                newRow.Cells[0].Value = ListbkID[i];
                newRow.Cells[1].Value = ListbkDate[i];
                newRow.Cells[2].Value = ListbkDuration[i];
                newRow.Cells[3].Value = ListrID[i];
                newRow.Cells[4].Value = ListbID[i];
                newRow.Cells[5].Value = ListrcID[i];
                bkHistory.Rows.Add(newRow);
            }
            reader.Close();
            conn.Close();
        }

        private void bkHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                DataGridViewButtonColumn buttonColumn1 = (DataGridViewButtonColumn)bkHistory.Columns["bID"];
                DataGridViewButtonColumn buttonColumn2 = (DataGridViewButtonColumn)bkHistory.Columns["rcID"];
                if (bkHistory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == buttonColumn2.Index)
                    {
                        // Handle buttonColumn1 click
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)bkHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string tagValue = buttonCell.Value.ToString();
                        ManagerRcVp myForm = new ManagerRcVp();
                        myForm.TagValue = tagValue;
                        myForm.ShowDialog();
                    }
                    else if (e.ColumnIndex == buttonColumn1.Index)
                    {
                        // Handle buttonColumn2 click
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)bkHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string tagValue = buttonCell.Value.ToString();
                        ManagerGBkB myForm = new ManagerGBkB();
                        myForm.TagValue = tagValue;
                        myForm.ShowDialog();
                    }
                }
            }
            catch(Exception ex) { }
         }
    }
}
