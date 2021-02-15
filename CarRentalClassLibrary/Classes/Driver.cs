using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary.Classes
{
    public class Driver
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string licenceNumber { get; set; }
        public string licenceExpiration { get; set; }
        public int hoursWorked { get; set; }

        public Driver()
        {

        }

        public Driver(string FirstName, string LastName, string Email, string PhoneNumber, string LicenceNumber, string LicenceExpiration, int HoursWorked)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.licenceNumber = LicenceNumber;
            this.licenceExpiration = LicenceExpiration;
            this.hoursWorked = HoursWorked;
        }
    }
}
