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
            try
            {
                string connString = "server = localhost ;" +
               " uid=root;" +
               " pwd = '' ; " +
               "database = hotel";

                string query = "SELECT * FROM Users";
                string Role = txtRole.Text;
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                switch (Role) 
                {
                    case "Receptionist":
                        MySqlConnection conn = new MySqlConnection(connString);
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(query, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read()) 
                        {
                            string username= reader.GetString(1);
                            string password= reader.GetString(2);
                            string role = reader.GetString(3);
                            if (role == Role) 
                            {
                                bool temp = Person.Login(Username,username,Password,password);
                                if (temp)
                                {
                                    MessageBox.Show("Successfully Signed in");
                                    this.Hide();
                                    new ReceptionistHome().ShowDialog();
                                    this.Close();
                                    break;
                                }
                                else 
                                {
                                    MessageBox.Show("Incorrect Credentials, Please Try again or Contact Administrator");
                                break;
                                }
                            }
                        }
                        conn.Close();
                        break;
                    case "Manager":
                        MySqlConnection conn1 = new MySqlConnection(connString);
                        conn1.Open();
                        MySqlCommand command1 = new MySqlCommand(query, conn1);
                        MySqlDataReader reader1 = command1.ExecuteReader();
                        while (reader1.Read())
                        {
                            string username = reader1.GetString(1);
                            string password = reader1.GetString(2);
                            string role = reader1.GetString(3);
                            if (role == Role)
                            {
                                bool temp = Person.Login(Username, username, Password, password);
                                if (temp)
                                {
                                    MessageBox.Show("Successfully Signed in");
                                    this.Hide();
                                    new ManagerHome().ShowDialog();
                                    this.Close();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Credentials, Please Try again or Contact Administrator");
                                    break;
                                }
                            }
                        }
                        conn1.Close();
                        break;
                    case "Admin":
                    MySqlConnection conn2 = new MySqlConnection(connString);
                    conn2.Open();
                    MySqlCommand command2 = new MySqlCommand(query, conn2);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        string username = reader2.GetString(1);
                        string password = reader2.GetString(2);
                        string role = reader2.GetString(3);
                        if (role == Role)
                        {
                            bool temp = Person.Login(Username, username, Password, password);
                            if (temp)
                            {
                                MessageBox.Show("Successfully Signed in");
                                this.Hide();
                                new AdminHome().ShowDialog();
                                this.Close();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Credentials, Please Try again or Contact Administrator");
                                break;
                            }
                        }
                    }
                    conn2.Close();
                    break;
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().ShowDialog();
            this.Close();
        }
    }
}
