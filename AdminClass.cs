using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    public class AdminClass : Person
    {
        private string aID;
        private int id;
        private byte[] aProfilePic;

        public string AID
        {
            get { return aID; }
            set { aID = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public byte[] AProfilePic
        {
            get { return aProfilePic; }
            set { aProfilePic = value; }
        }
        public AdminClass(string aID, string name,
                                 string dob, string gender,
                                 string pNumber, string email, int id, byte[] aProfilePic)
                                 : base(name, dob, gender, pNumber, email)
        {
            AID = aID;
            Name = name;
            DoB = dob;
            Gender = gender;
            PNumber = pNumber;
            Email = email;
            ID = id;
            AProfilePic = aProfilePic;
        }
    }
}
