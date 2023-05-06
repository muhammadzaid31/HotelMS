using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    internal class RoomClass
    {
        private string rID;
        private string rType;
        private int rPrice;
        private bool rStatus;

        public string RID 
        {
            get { return rID; }
            set { rID = value; }    
        }
        public string RType 
        {
            get {return rType; }
            set { rType = value; }    
        }
        public int RPrice 
        {
            get { return rPrice; }
            set { rPrice = value; }
        }
        
        public bool RStatus 
        {
            get { return rStatus; }
            set { rStatus = value; }
        }
        public RoomClass(string rID, string rType, int rPrice, bool rStatus) 
        {
            RID = rID;
            RType = rType;
            RPrice = rPrice;
            RStatus = rStatus;
        }
    }
}
