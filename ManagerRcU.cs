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
using MySql.Data.MySqlClient;

namespace HotelMS
{
    public partial class ManagerRcU : Form
    {
        public ManagerRcU()
        {
            InitializeComponent();
        }

        private string filePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public byte[] rcPfp;

        private void submit_Click(object sender, EventArgs e)
        {
            string connString = "server = localhost ;" +
            " uid=root;" +
            " pwd = '' ; " +
            "database = hotel";

            string rcID = txtUID.Text;
            string query = "SELECT * FROM Receptionists WHERE rcID=@rcID";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@rcID", rcID);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            txtrcID.Text = reader["rcID"].ToString();
            txtName.Text = reader["Name"].ToString();
            dtp.Value = DateTime.Parse(reader["DoB"].ToString());
            txtGender.Text = reader["Gender"].ToString();
            txtPhone.Text = reader["Phone"].ToString();
            txtEmail.Text = reader["Email"].ToString();
            txtID.Text = reader["ID"].ToString();
            int RCID = int.Parse(reader["ID"].ToString());
            byte[] data = (byte[])reader["rcProfilePic"];


            MemoryStream ms = new MemoryStream(data);


            Bitmap bmp = new Bitmap(ms);


            pB1.Image = bmp;

            reader.Close();
            string query1 = "SELECT * FROM users WHERE ID = @ID ";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@ID", RCID);
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
                rcPfp = File.ReadAllBytes(filePath);
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MemoryStream ms1 = new MemoryStream(rcPfp);


                Bitmap bmp1 = new Bitmap(ms1);
                pB1.Image = bmp1;
            }
            MemoryStream ms = new MemoryStream(rcPfp);


            Bitmap bmp = new Bitmap(ms);
            pB1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
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
            Image image = pB1.Image;
            byte[] rcPfp;
            using (MemoryStream stream = new MemoryStream())
            {

                image.Save(stream, ImageFormat.Jpeg);
                rcPfp = stream.ToArray();
            }
            ReceptionistClass rc1 = new ReceptionistClass(rcID, rcName, rcDoB,
                rcGender, rcPhone, rcEmail, rceID, rcPfp);
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query = "UPDATE users SET ID=@ID, Username=@User, Password=@Pass, Role=@Role WHERE ID=@ID";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", rceID);
            command.Parameters.AddWithValue("@User", rcUsername);
            command.Parameters.AddWithValue("@Pass", rcPassword);
            command.Parameters.AddWithValue("@Role", "Receptionist");
            string query1 = "Update Receptionists SET rcID=@rcID, Name=@rcName, DoB=@rcDoB, Gender = @rcGender, " +
                "Phone=@rcPhone,Email=@rcEmail, ID = @ID1, rcProfilePic=@rcProfilePic WHERE ID=@ID1";
            command.ExecuteNonQuery();
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
            MessageBox.Show("Successfully Updated Receptionist account");
            conn.Close();
            this.Close();
        }
    }
}
