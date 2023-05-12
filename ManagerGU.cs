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
    public partial class ManagerGU : Form
    {
        public ManagerGU()
        {
            InitializeComponent();
        }


        private string filePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public byte[] rcPfp;
        private void submit_Click(object sender, EventArgs e)
        {
            try {
                string connString = "server = localhost ;" +
                " uid=root;" +
                " pwd = '' ; " +
                "database = hotel";

                string gID = txtguest.Text;
                string query = "SELECT * FROM guest WHERE gID=@gID";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@gID", gID);
                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                txtgID.Text = reader["gID"].ToString();
                txtName.Text = reader["Name"].ToString();
                dtp.Value = DateTime.Parse(reader["DoB"].ToString());
                txtGender.Text = reader["Gender"].ToString();
                txtPhone.Text = reader["Phone"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtnov.Text = reader["NumberOfVisits"].ToString();
                byte[] data = (byte[])reader["gProfilePic"];
                MemoryStream ms = new MemoryStream(data);
                Bitmap bmp = new Bitmap(ms);
                pB1.Image = bmp;
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter  Guest ID in Correct Format");
            }
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
            string gID = txtgID.Text;
            string gName = txtName.Text;
            DateTime selectedDate = dtp.Value;
            string gDoB = selectedDate.ToString("dd-MM-yy");
            string gGender = txtGender.Text;
            string gPhone = txtPhone.Text;
            string gEmail = txtEmail.Text;
            int nov = int.Parse(txtnov.Text);
            
            Image image = pB1.Image;
            byte[] gPfp;
            using (MemoryStream stream = new MemoryStream())
            {

                image.Save(stream, ImageFormat.Jpeg);
                gPfp = stream.ToArray();
            }
            string connString = "server = localhost ;" +
          " uid=root;" +
          " pwd = '' ; " +
          "database = hotel";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string query1 = "Update guest SET gID=@gID, Name=@gName, DoB=@gDoB, Gender = @gGender, " +
                "Phone=@gPhone,Email=@gEmail, NumberOfVisits = @nov, gProfilePic=@gProfilePic WHERE gID=@guID";
            
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@gID", gID);
            command1.Parameters.AddWithValue("@guID", txtguest.Text.ToString());
            command1.Parameters.AddWithValue("@gName", gName);
            command1.Parameters.AddWithValue("@gDoB", gDoB);
            command1.Parameters.AddWithValue("@gGender",gGender);
            command1.Parameters.AddWithValue("@gPhone", gPhone);
            command1.Parameters.AddWithValue("@gEmail", gEmail);
            command1.Parameters.AddWithValue("@nov", nov);
            command1.Parameters.AddWithValue("@gProfilePic", gPfp);
            command1.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated Guest Profile");
            conn.Close();
            this.Close();
        }

        private void ManagerGU_Load(object sender, EventArgs e)
        {

        }
    }
}
