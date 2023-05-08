using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace HotelMS
{
    public partial class AdminRA : Form
    {
        public AdminRA()
        {
            InitializeComponent();
        }

        private void cB1_SelectedValueChanged(object sender, EventArgs e)
        {
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string connString = "server = localhost ;" +
      " uid=root;" +
      " pwd = '' ; " +
      "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string rID=txtrID.Text.ToString();
            string rType = cB1.Text.ToString();
            int rPrice = int.Parse(txtrPrice.Text.ToString());
            bool rStatus = bool.Parse(txtrStatus.Text.ToString());

            RoomClass r = new RoomClass(rID,rType,rPrice,rStatus);

            string query = "INSERT INTO rooms VALUES(@rID,@rType,@rPrice,@rStatus)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@rID",r.RID);
            command.Parameters.AddWithValue("@rType",r.RType);
            command.Parameters.AddWithValue("@rPrice",r.RPrice);
            command.Parameters.AddWithValue("@rStatus",r.RStatus);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Room added Successfully");
            this.Close();
        }
    }
}
