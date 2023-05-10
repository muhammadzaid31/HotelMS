using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    public class ManagerClass : Person
    {
        private string mID;
        private int id;
        private byte[] mProfilePic;

        public string MID
        {
            get { return mID; }
            set { mID = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public byte[] MProfilePic
        {
            get { return mProfilePic; }
            set { mProfilePic = value; }
        }
        public ManagerClass(string mID, string name,
                                 string dob, string gender,
                                 string pNumber, string email, int id, byte[] mProfilePic)
                                 : base(name, dob, gender, pNumber, email)
        {
            MID = mID;
            Name = name;
            DoB = dob;
            Gender = gender;
            PNumber = pNumber;
            Email = email;
            ID = id;
            MProfilePic = mProfilePic;
        }
        public static void ViewBookingDetails()
        {

        }
        public static void AddGuest()
        {

        }

        public static void AddReceptionist()
        {

        }
    }
}
