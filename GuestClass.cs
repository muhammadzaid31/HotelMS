using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    public class GuestClass : Person
    {
        private string gID;
        private int nov;
        private byte[] gProfilePic;

        public string GID
        {
            get { return gID; }
            set { gID = value; }
        }

        public int NoV
        {
            get { return nov; }
            set { nov = value; }
        }

        public byte[] GProfilePic
        {
            get { return gProfilePic; }
            set { gProfilePic = value; }
        }

        public GuestClass(string gID, string name,
                          string dob, string gender,
                          string pNumber, string email,
                          int nov, byte[] gProfilePic)
            : base(name, dob, gender, pNumber, email)
        {
            GID = gID;
            Name = name;
            DoB = dob;
            Gender = gender;
            PNumber = pNumber;
            Email = email;
            NoV = nov;
            GProfilePic = gProfilePic;
        }
    }
}
