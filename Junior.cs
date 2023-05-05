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
    public partial class Junior : Form
    {
        public Junior()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest().ShowDialog();    
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Junior1().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Junior2().ShowDialog(); 
        }
    }
}
