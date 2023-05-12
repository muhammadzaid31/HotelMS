using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DryIoc;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace HotelMS
{
    public partial class AdminMU : Form
    {

        private string filePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public byte[] imageData;
        public AdminMU()
        {
            InitializeComponent();
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
            int maID = int.Parse(txtID.Text.ToString());
            string mUsername = txtUsername.Text;
            string mPassword = txtPassword.Text;
           Image image = pB1.Image;
           byte[] mPfp;
            using (MemoryStream stream = new MemoryStream())
            {
                
                image.Save(stream, ImageFormat.Jpeg);
                mPfp = stream.ToArray();
            }

          
            if (string.IsNullOrEmpty(filePath)==false)
            {
                
                MemoryStream ms2 = new MemoryStream(imageData);
                Bitmap bmp2 = new Bitmap(ms2);
                pB1.Image = bmp2;
            }
            if (!int.TryParse(txtID.Text, out maID))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            ManagerClass m1 = new ManagerClass(mID,mName, mDoB,
               mGender, mPhone, mEmail, maID, mPfp);
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query = "UPDATE users SET ID=@ID, Username=@User, Password=@Pass, Role=@Role " +
                "WHERE ID=@ID";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", maID);
            command.Parameters.AddWithValue("@User", mUsername);
            command.Parameters.AddWithValue("@Pass", mPassword);
            command.Parameters.AddWithValue("@Role", "Manager");
            string query1 = "Update Managers SET mID=@mID, Name=@mName, DoB=@mDoB, " +
                "Gender = @mGender, " +
                "Phone=@mPhone,Email=@mEmail, ID = @ID1, mProfilePic=@mProfilePic WHERE ID=@ID1";
            command.ExecuteNonQuery();
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@mID", m1.MID);
            command1.Parameters.AddWithValue("@mName", m1.Name);
            command1.Parameters.AddWithValue("@mDoB", m1.DoB);
            command1.Parameters.AddWithValue("@mGender", m1.Gender);
            command1.Parameters.AddWithValue("@mPhone", m1.PNumber);
            command1.Parameters.AddWithValue("@mEmail", m1.Email);
            command1.Parameters.AddWithValue("@ID1", m1.ID);
            command1.Parameters.AddWithValue("@mProfilePic", m1.MProfilePic);
            command1.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated Managers account");
            conn.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
           " uid=root;" +
           " pwd = '' ; " +
           "database = hotel";

            string query = "SELECT * FROM Managers WHERE mID=@mID";
            string mid = txtmaID.Text ;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@mID", mid);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            txtmID.Text = reader["mID"].ToString();
            txtName.Text = reader["Name"].ToString();
            dtp.Value = DateTime.Parse(reader["DoB"].ToString());
            txtGender.Text = reader["Gender"].ToString();
            txtPhone.Text = reader["Phone"].ToString();
            txtEmail.Text = reader["Email"].ToString();
            txtID.Text = reader["ID"].ToString();
            int tempid = int.Parse(reader["ID"].ToString());
            byte[] data = (byte[])reader["mProfilePic"];


            MemoryStream ms = new MemoryStream(data);


            Bitmap bmp = new Bitmap(ms);


            pB1.Image = bmp;

            reader.Close();
            string query1 = "SELECT * FROM users WHERE ID=@ID";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@ID", tempid);
            MySqlDataReader reader1 = command.ExecuteReader();

            reader1.Read();
            txtUsername.Text = reader1.GetString(1).ToString();
            txtPassword.Text = reader1.GetString(2).ToString();
            reader1.Close();
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
            if (string.IsNullOrEmpty(filePath))
            {
                MemoryStream ms1 = new MemoryStream(imageData);


                Bitmap bmp1 = new Bitmap(ms1);
                pB1.Image = bmp1;

            }
            MemoryStream ms = new MemoryStream(imageData);


            Bitmap bmp = new Bitmap(ms);
            pB1.Image = bmp;

        }

        private void AdminMU_Load(object sender, EventArgs e)
        {

        }
    }
}
