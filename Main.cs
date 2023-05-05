using Org.BouncyCastle.Asn1.Ess;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest().ShowDialog();
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().ShowDialog(); 
            this.Close();
        }
    }
}
