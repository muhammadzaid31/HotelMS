namespace TestProject
{
    using NUnit.Framework;
    using HotelMS;
    using System.Security.Cryptography;
    using System.Reflection;
    using System.Xml.Linq;
    using System;

    public class Tests
    {

        [Test]
        public void ReceptionistClass_InitializedCorrectly_ShouldCreateReceptionistObject()
        {
            // Arrange
            string rcID = "RC23";
            string name = "Frenkie De Jong";
            string dob = "17/06/2005";
            string gender = "M";
            string pNumber = "0555123454";
            string email = "frenkiedejong@fcb.com";
            int id = 1;
            byte[] rProfilePic = new byte[0];

            // Act
            ReceptionistClass receptionist = new ReceptionistClass(rcID, name, dob, gender, pNumber, email, id, rProfilePic);

            // Assert
            Assert.That(receptionist.RCID, Is.EqualTo(rcID));
            Assert.That(receptionist.Name, Is.EqualTo(name));
            Assert.That(receptionist.DoB, Is.EqualTo(dob));
            Assert.That(receptionist.Gender, Is.EqualTo(gender));
            Assert.That(receptionist.PNumber, Is.EqualTo(pNumber));
            Assert.That(receptionist.Email, Is.EqualTo(email));
            Assert.That(receptionist.ID, Is.EqualTo(id));
            Assert.That(receptionist.RProfilePic, Is.EqualTo(rProfilePic));
        }

        [Test]
        public void AdminClass_InitializedCorrectly_ShouldCreateAdminObject()
        {
            // Arrange
            string aID = "A01";
            string name = "Pedri Gonzalez";
            string dob = "01/01/2000";
            string gender = "M";
            string pNumber = "0555123421";
            string email = "Pedrigonzalez@fcb.com";
            int id = 5;
            byte[] aProfilePic = new byte[0];

            // Act
            AdminClass admin = new AdminClass(aID, name, dob, gender, pNumber, email, id, aProfilePic);

            // Assert
            Assert.That(admin.AID, Is.EqualTo(aID));
            Assert.That(admin.Name, Is.EqualTo(name));
            Assert.That(admin.DoB, Is.EqualTo(dob));
            Assert.That(admin.Gender, Is.EqualTo(gender));
            Assert.That(admin.PNumber, Is.EqualTo(pNumber));
            Assert.That(admin.Email, Is.EqualTo(email));
            Assert.That(admin.ID, Is.EqualTo(id));
            Assert.That(admin.AProfilePic, Is.EqualTo(aProfilePic));
        }

        [Test]
        public void Manager_Constructor_Initializes_Properties_ShouldCreateManagerObject()
        {
            // Arrange
            string mID = "M01";
            string name = "Lionel Messi";
            string dob = "04-07-2000";
            string gender = "Male";
            string pNumber = "0555151236";
            string email = "lmessi2000@fcb.com";
            int id = 1;
            byte[] mProfilePic = new byte[] { 0x00, 0x01, 0x02 };

            // Act
            ManagerClass manager = new ManagerClass(mID, name, dob, gender, pNumber, email, id, mProfilePic);

            // Assert
            Assert.That(manager.MID, Is.EqualTo(mID));
            Assert.That(manager.Name, Is.EqualTo(name));
            Assert.That(manager.DoB, Is.EqualTo(dob));
            Assert.That(manager.Gender, Is.EqualTo(gender));
            Assert.That(manager.PNumber, Is.EqualTo(pNumber));
            Assert.That(manager.Email, Is.EqualTo(email));
            Assert.That(manager.ID, Is.EqualTo(id));
            Assert.That(manager.MProfilePic, Is.EqualTo(mProfilePic));
        }

        [Test]
        public void BookingDetails_Constructor_Initializes_Properties_ShouldCreateBookingDetailsObject() 
        {

            // Arrange
            string bkID = "M01";
            string bkDate = "31-07-2022";
            string checkOutDate = "22-09-2023";
            int bkDuration = 8;
            string rID = "R08";
            string rcID = "RC20";
            string mID = "M03";
            string gID = "G02";

            // Act
            BookingDetailsClass booking_details = new BookingDetailsClass(bkID, bkDate, checkOutDate, bkDuration,
                                      rID, rcID, mID, gID);

            // Assert
            Assert.That(booking_details.BkID, Is.EqualTo(bkID));
            Assert.That(booking_details.BkDate, Is.EqualTo(bkDate));
            Assert.That(booking_details.CheckOutDate, Is.EqualTo(checkOutDate));
            Assert.That(booking_details.BkDuration, Is.EqualTo(bkDuration));
            Assert.That(booking_details.RID, Is.EqualTo(rID));
            Assert.That(booking_details.RCID, Is.EqualTo(rcID));
            Assert.That(booking_details.MID, Is.EqualTo(mID));
            Assert.That(booking_details.GID, Is.EqualTo(gID));
        }

        [Test]
        public void Bill_Constructor_Initializes_Properties_ShouldCreateBillObject()
        {

            // Arrange
            
                string bID = "B45";
                string bDate = "02-09-2022";
                int bAmount = 5000;
                int bFine = 1000;
                int bTotal = 6000;
                string bkID = "BK45";
     
            // Act
            BillClass booking_details = new BillClass(bID,bDate,bAmount, bFine, bTotal, bkID);

            // Assert
            Assert.That(booking_details.BID, Is.EqualTo(bID));
            Assert.That(booking_details.BDate, Is.EqualTo(bDate));
            Assert.That(booking_details.BAmount, Is.EqualTo(bAmount));
            Assert.That(booking_details.BFine, Is.EqualTo(bFine));
            Assert.That(booking_details.BTotal, Is.EqualTo(bTotal));
            Assert.That(booking_details.BkID, Is.EqualTo(bkID));


        }


        [Test]
        public void GuestClass_Constructor_WithValidArguments_ShouldCreateGuestObject()
        {
            // Arrange
            string gID = "G01";
            string name = "Pablo Gavi";
            string dob = "01/01/2000";
            string gender = "F";
            string pNumber = "0555345678";
            string email = "PabloGavi@fcb.com";
            int nov = 8;
            byte[] gProfilePic = new byte[] { 0x00, 0x01, 0x02 };

            // Act
            var guest = new GuestClass(gID, name, dob, gender, pNumber, email, nov, gProfilePic);

            // Assert
            Assert.IsNotNull(guest);
            Assert.That(guest.GID, Is.EqualTo(gID));
            Assert.That(guest.Name, Is.EqualTo(name));
            Assert.That(guest.DoB, Is.EqualTo(dob));
            Assert.That(guest.Gender, Is.EqualTo(gender));
            Assert.That(guest.PNumber, Is.EqualTo(pNumber));
            Assert.That(guest.Email, Is.EqualTo(email));
            Assert.That(guest.NoV, Is.EqualTo(nov));
            Assert.That(guest.GProfilePic, Is.EqualTo(gProfilePic));
        }
    }
}