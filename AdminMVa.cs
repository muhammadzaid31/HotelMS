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
    public partial class AdminMVa : Form
    {
        public AdminMVa()
        {
            InitializeComponent();
        }

        private void AdminMVa_Load(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
           " uid=root;" +
           " pwd = '' ; " +
           "database = hotel";

            string query = "SELECT mID, Name, DoB, Gender, Phone, Email,ID FROM Managers";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            ArrayList ListmID = new ArrayList();
            ArrayList ListName = new ArrayList();
            ArrayList ListDoB = new ArrayList();
            ArrayList ListGender = new ArrayList();
            ArrayList ListPhone = new ArrayList();
            ArrayList ListEmail = new ArrayList();
            ArrayList ListID = new ArrayList();

            while (reader.Read())
            {
                ListmID.Add(reader["mID"].ToString());
                ListName.Add(reader["Name"].ToString());
                ListDoB.Add(reader["DoB"].ToString());
                ListGender.Add(reader["Gender"].ToString());
                ListPhone.Add(reader["Phone"].ToString());
                ListEmail.Add(reader["Email"].ToString());
                ListID.Add(reader["ID"].ToString());

            }
            Managers.Rows.Clear();
            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Managers);
                newRow.Cells[0].Value = ListmID[i];
                newRow.Cells[1].Value = ListName[i];
                newRow.Cells[2].Value = ListDoB[i];
                newRow.Cells[3].Value = ListGender[i];
                newRow.Cells[4].Value = ListPhone[i];
                newRow.Cells[5].Value = ListEmail[i];
                newRow.Cells[6].Value = ListID[i];
                Managers.Rows.Add(newRow);
            }
            reader.Close();
            conn.Close();
        }

        private void Managers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Managers.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)Managers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string tagValue = buttonCell.Value.ToString();
                AdminMVp myForm = new AdminMVp();
                myForm.TagValue = tagValue;
                myForm.ShowDialog();
            }
        }
    }
}
