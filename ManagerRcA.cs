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
    public partial class ManagerRcA : Form
    {
        public ManagerRcA()
        {
            InitializeComponent();
        }
        private string filePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public byte[] imageData;

        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

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

        public void button2_Click(object sender, EventArgs e)
        {
            string rcID = txtrcID.Text;
            string rcName = txtName.Text;
            DateTime selectedDate = dtp.Value;
            string rcDoB = selectedDate.ToString("dd-MM-yy");
            string rcGender = txtGender.Text;
            string rcPhone = txtPhone.Text;
            string rcEmail = txtEmail.Text;
            int rceID = int.Parse(txtID.Text);
            string rcUsername = txtUsername.Text;
            string rcPassword = txtPassword.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select an image file first.");
                return;
            }
            byte[] rcPfp = imageData;
            if (!int.TryParse(txtID.Text, out rceID))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            ReceptionistClass rc1 = new ReceptionistClass(rcID, rcName, rcDoB,
                rcGender, rcPhone, rcEmail, rceID, rcPfp);


            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query = "INSERT INTO `users`(`ID`, `Username`, `Password`, `Role`) " +
                "VALUES (@ID,@User,@Pass,@Role)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", rceID);
            command.Parameters.AddWithValue("@User", rcUsername);
            command.Parameters.AddWithValue("@Pass", rcPassword);
            command.Parameters.AddWithValue("@Role", "Receptionist");

            command.ExecuteNonQuery();
            string query1 = "INSERT INTO `receptionists`(`rcID`, `Name`, `DoB`, `Gender`, `Phone`, " +
                "`Email`, `ID`, `rcProfilePic`) " +
                "VALUES (@rcID,@rcName,@rcDob,@rcGender,@rcPhone,@rcEmail,@ID1,@rcProfilePic)";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@rcID", rc1.RCID);
            command1.Parameters.AddWithValue("@rcName", rc1.Name);
            command1.Parameters.AddWithValue("@rcDoB", rc1.DoB);
            command1.Parameters.AddWithValue("@rcGender", rc1.Gender);
            command1.Parameters.AddWithValue("@rcPhone", rc1.PNumber);
            command1.Parameters.AddWithValue("@rcEmail", rc1.Email);
            command1.Parameters.AddWithValue("@ID1", rceID);
            command1.Parameters.AddWithValue("@rcProfilePic", rc1.RProfilePic);
            command1.ExecuteNonQuery();
            MessageBox.Show("Successfully created Receptionist account");
            conn.Close();
            this.Close();
        }

        private void ManagerRcA_Load(object sender, EventArgs e)
        {

        }
    }
}
