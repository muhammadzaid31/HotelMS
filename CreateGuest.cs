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
using MySql.Data.MySqlClient;
namespace HotelMS
{
    public partial class CreateGuest : Form
    {
        public CreateGuest()
        {
            InitializeComponent();
        }

        private string filePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public byte[] imageData;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";


            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                button1.Text = "Successfully Selected";
                filePath = openFileDialog1.FileName;

                // Convert the selected image to a byte array
                imageData = File.ReadAllBytes(filePath);
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
         
            string gID = txtgID.Text;
            string gName = txtName.Text;
            DateTime selectedDate = dtp.Value;
            string gDoB = selectedDate.ToString("dd-MM-yy");
            string gGender = txtGender.Text;
            string gPhone = txtPhone.Text;
            string gEmail = txtEmail.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select an image file first.");
                return;
            }
            byte[] gPfp = imageData;
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            
            string query1 = "INSERT INTO `guest`(`gID`, `Name`, `DoB`, `Gender`, `Phone`, " +
                "`Email`, `gProfilePic`) " +
                "VALUES (@gID,@gName,@gDoB,@gGender,@gPhone,@gEmail,@gProfilePic)";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@gID", gID);
            command1.Parameters.AddWithValue("@gName", gName);
            command1.Parameters.AddWithValue("@gDoB", gDoB);
            command1.Parameters.AddWithValue("@gGender", gGender);
            command1.Parameters.AddWithValue("@gPhone", gPhone);
            command1.Parameters.AddWithValue("@gEmail", gEmail);
            command1.Parameters.AddWithValue("@gProfilePic", gPfp);
            command1.ExecuteNonQuery();
            MessageBox.Show("Successfully created Guest Profile");
            conn.Close();
            this.Close();
        }
    }
}
