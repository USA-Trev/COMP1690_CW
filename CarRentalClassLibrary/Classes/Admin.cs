using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary
{
    public class Admin
    {
        public string username { get; set; }
        public string password { get; set; }

        public Admin()
        {
            
        }

        public Admin(string Username, string Password)
        {
            this.username = Username;
            this.password = Password;
        }
    }
}
