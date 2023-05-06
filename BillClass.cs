using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    internal class BillClass
    {
        private string bID;
        private int bAmount;
        private string bDate;
        private string bkID;

        public string BID
        {
            get { return bID; }
            set { bID = value; }
        }

        public int BAmount
        {
            get { return bAmount; }
            set { bAmount = value; }
        }

        public string BDate
        {
            get { return bDate; }
            set { bDate = value; }
        }

        public string BkID
        {
            get { return bkID; }
            set { bkID = value; }
        }
        public BillClass(string bID, int bAmount, string bDate, string bkID) 
        {
            BID = bID;
            BAmount = bAmount; 
            BDate = bDate;
            BkID = bkID;
        }
    }
}
