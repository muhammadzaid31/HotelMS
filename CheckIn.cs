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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }
        private string tagValue;
        public string TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }
        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateGuest().ShowDialog();
            CreateBooking myForm = new CreateBooking();
            myForm.RID = this.TagValue;
            myForm.ShowDialog();
            this.Show();
        }

        private void btnExistingGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateBooking().ShowDialog();
            this.Show();
        }
    }
}
