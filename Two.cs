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
    public partial class Two : Form
    {
        public Two()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest().ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Two1().ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Two2().ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Two3().ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Two4().ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
