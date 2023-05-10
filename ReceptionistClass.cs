using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelMS
{
    public class ReceptionistClass : Person
    {
        private string rcID;
        private int id;
        private byte[] rProfilePic;

        public string RCID 
        {
            get { return rcID; }
            set { rcID = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public byte[] RProfilePic 
        {
            get { return rProfilePic; }
            set { rProfilePic = value; }
        }
        public ReceptionistClass(string rcID, string name, 
                                 string dob, string gender, 
                                 string pNumber, string email, int id, byte[] rProfilePic) 
                                 : base(name, dob, gender, pNumber, email) 
        {
            RCID = rcID;
            Name = name;
            DoB = dob;
            Gender = gender;
            PNumber = pNumber;
            Email = email;
            ID = id;
            RProfilePic = rProfilePic;
        }

        public static void DisplayReceptionists() 
        {

        }

        public static void CreateBooking() 
        {

        }
    }
}
