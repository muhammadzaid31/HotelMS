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
    public partial class AdminRVa : Form
    {
        public AdminRVa()
        {
            InitializeComponent();
        }

        private void AdminRVa_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
           " uid=root;" +
           " pwd = '' ; " +
           "database = hotel";

            string query = "SELECT * FROM Rooms";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
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
            Rooms.Rows.Clear();
            for (int i = 0; i < ListrID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Rooms);
                newRow.Cells[0].Value = ListrID[i];
                newRow.Cells[1].Value = ListrType[i];
                newRow.Cells[2].Value = ListrPrice[i];
                newRow.Cells[3].Value = ListrStatus[i];
               Rooms.Rows.Add(newRow);
            }
            reader.Close();
            conn.Close();
        }
    }
}
