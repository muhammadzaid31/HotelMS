using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully Signed Out");
            new SignIn().ShowDialog();
            this.Close();
        }

        private void btnReceptionists_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminRc().ShowDialog(); 
            this.Close();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminM().ShowDialog();
            this.Close();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminR().ShowDialog();
            this.Close();
        }
    }
}
