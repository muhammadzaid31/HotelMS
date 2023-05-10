using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    public class BookingDetailsClass
    {
        private string bkID;
        private string bkDate;
        private string checkOutDate;
        private int bkDuration;
        private string rID;
        private string rcID;
        private string mID;
        private string gID;

        public string BkID
        {
            get { return bkID; }
            set { bkID = value; }
        }
        public string BkDate
        {
            get { return bkDate; }
            set { bkDate = value; }
        }
        public string CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        public int BkDuration
        {
            get { return bkDuration; }
            set { bkDuration = value; }

        }
        public string RID
        {
            get { return rID; }
            set { rID = value; }
        }
        public string RCID
        {
            get { return rcID; }
            set { rcID = value; }
        }
        public string MID
        {
            get { return mID; }
            set { mID = value; }
        }
        public string GID
        {
            get { return gID; }
            set { gID = value; }
        }

        public ManagerClass ManagerClass
        {
            get => default;
            set
            {
            }
        }

        public ReceptionistClass ReceptionistClass
        {
            get => default;
            set
            {
            }
        }

        public BillClass BillClass
        {
            get => default;
            set
            {
            }
        }

        public BookingDetailsClass(string bkID, string bkDate,
                                   string checkOutDate, int bkDuration,
                                   string rID, string rcID,
                                   string mID, string gID)
        {
            BkID = bkID;
            BkDate = bkDate;
            CheckOutDate = checkOutDate;
            BkDuration = bkDuration;
            RID = rID;
            RCID = rcID;
            MID = mID;
            GID = gID;
        }

        public static void UpdateBookingDetails ()
        {

        }
    }
}
