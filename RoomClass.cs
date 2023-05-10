using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    public class RoomClass
    {
        private string rID;
        private string rType;
        private int rPrice;
        private bool rStatus;

        public string RID { get; set; }
        public string RType { get; set; }
        public int RPrice { get; set; }
        public bool RStatus { get; set; }
        


        public ReceptionistClass ReceptionistClass
        {
            get => default;
            set
            {
            }
        }

        public AdminClass AdminClass
        {
            get => default;
            set
            {
            }
        }

        public BookingDetailsClass BookingDetailsClass
        {
            get => default;
            set
            {
            }
        }

        public RoomClass(string rID, string rType, int rPrice, bool rStatus) 
        {
            RID = rID;
            RType = rType;
            RPrice = rPrice;
            RStatus = rStatus;
        }
        public static void ViewRooms() 
        {

        }
    }
}
