using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DryIoc;
using MySql.Data.MySqlClient;


namespace HotelMS
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                string connString = "server = localhost ;" +
               " uid=root;" +
               " pwd = '' ; " +
               "database = hotel";


                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    // MySQL query to check user credentials
                    string query = $"SELECT * FROM users WHERE username=@user AND password=@pass";
                    string role = txtRole.Text ;    
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user",txtUsername.Text);
                        command.Parameters.AddWithValue("@pass", txtPassword.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                        reader.Read();
                            // If the query returns a result, user is authenticated
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Successfully Signed in");
                                this.Hide();

                                // Redirect to appropriate form based on user role
                                if (role == "Admin")
                                {
                                    AdminHome myForm = new AdminHome();
                                    myForm.ShowDialog();
                                    this.Close();
                                }
                                else if (role == "Receptionist")
                                {
                                    ReceptionistHome myForm2 = new ReceptionistHome();
                                    myForm2.UID = int.Parse(reader.GetString(0));
                                    myForm2.ShowDialog();
                                    this.Close();
                                }
                                else if (role == "Manager")
                                {
                                    ManagerHome myForm1 = new ManagerHome();
                                    myForm1.UID = int.Parse(reader.GetString(0));
                                    myForm1.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter a Valid Role");
                                this.Hide();
                                new SignIn().ShowDialog();
                                this.Close();
                            }
                            }
                            else 
                            {
                                MessageBox.Show("Please Enter Valid Details");
                                this.Hide();
                                new SignIn().ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
