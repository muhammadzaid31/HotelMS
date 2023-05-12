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

        public string BID{get; set;}

        public string BDate{get; set;}

        public int BAmount{ get; set;}

        public int BTotal{ get; set; }
        public int BFine { get; set; }

        public string BkID{ get; set; }

        public ReceptionistClass ReceptionistClass
        {
            get => default;
            set
            {
            }
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

        public static void CalculateBill ()
       {

       }
    }
}
