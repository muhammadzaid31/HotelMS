using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    public class BillClass
    {
        private string bID;
        private string bDate;
        private int bAmount;
        private int bFine;
        private int bTotal;
        private string bkID;

        public string BID
        {
            get { return bID; }
            set { bID = value; }
        }

        public string BDate
        {
            get { return bDate; }
            set { bDate = value; }
        }

        public int BAmount
        {
            get { return bAmount; }
            set { bAmount = value; }
        }
        public int BFine
        {
            get { return bFine; }
            set { bFine = value; }
        }

        public int BTotal
        {
            get { return bTotal; }
            set { bTotal = value; }
        }

        public string BkID
        {
            get { return bkID; }
            set { bkID = value; }
        }
        public BillClass(string bID, string bDate, int bAmount, int bFine, int bTotal, string bkID) 
        {
            BID = bID;
            BDate = bDate;
            BAmount = bAmount;
            BFine = bFine;
            BTotal = bTotal;
            BkID = bkID;
        }
    }
}
