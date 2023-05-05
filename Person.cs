using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMS
{
    internal class Person
    {
        private string name;
        private string dob;
        private string gender;
        private string pNumber;
        private string email;

        public string Name 
        {
            get { return name; }
            set { name = value; }

        }
        public string DoB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        public string PNumber
        {
            get { return pNumber; }
            set { pNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person(string name, string dob, string gender, string pNumber, string email  ) 
        {
            Name = name;
            DoB = dob;
            Gender = gender;
            PNumber = pNumber;
            Email = email;                
        }
            
    }
}
