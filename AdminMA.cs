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
    public partial class AdminMA : Form
    {
        private string filePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public byte[] imageData;
        public AdminMA()
        {
            InitializeComponent();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string mID = txtmID.Text;
            string mName = txtName.Text;
            DateTime selectedDate = dtp.Value;
            string mDoB = selectedDate.ToString("dd-MM-yy");
            string mGender = txtGender.Text;
            string mPhone = txtPhone.Text;
            string mEmail = txtEmail.Text;
            int maID = int.Parse(txtID.Text);
            string mUsername = txtUsername.Text;
            string mPassword = txtPassword.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select an image file first.");
                return;
            }
            byte[] mPfp = imageData;
            if (!int.TryParse(txtID.Text, out maID))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            ManagerClass m1 = new ManagerClass(mID, mName, mDoB,
                mGender, mPhone, mEmail, maID, mPfp);


            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query = "INSERT INTO `users`(`ID`, `Username`, `Password`, `Role`) " +
                "VALUES (@ID,@User,@Pass,@Role)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", maID);
            command.Parameters.AddWithValue("@User", mUsername);
            command.Parameters.AddWithValue("@Pass", mPassword);
            command.Parameters.AddWithValue("@Role", "Manager");
            string query1 = "INSERT INTO `managers`(`mID`, `Name`, `DoB`, `Gender`, `Phone`, " +
                "`Email`, `ID`, `mProfilePic`) " +
                "VALUES (@mID,@mName,@mDob,@mGender,@mPhone,@mEmail,@ID1,@mProfilePic)";
            command.ExecuteNonQuery();
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@mID", m1.MID);
            command1.Parameters.AddWithValue("@mName", m1.Name);
            command1.Parameters.AddWithValue("@mDoB", m1.DoB);
            command1.Parameters.AddWithValue("@mGender", m1.Gender);
            command1.Parameters.AddWithValue("@mPhone", m1.PNumber);
            command1.Parameters.AddWithValue("@mEmail", m1.Email);
            command1.Parameters.AddWithValue("@ID1", maID);
            command1.Parameters.AddWithValue("@mProfilePic", m1.MProfilePic);
            command1.ExecuteNonQuery();
            MessageBox.Show("Successfully created Manager account");
            conn.Close();
            this.Close();
        }
    }
}
