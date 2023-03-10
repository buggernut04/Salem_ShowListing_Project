using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class Audience : User
    {
        // Audience are simply the typical user of this application.
        // No methods are implemented since that it's already defined in the
        // ShowMeter Class
        public Audience(string username, DateTime birthdate, char sex, string nationality, string email, string password) : base(username, birthdate, sex, nationality, email, password)
        {
        
        }

        public override string ToString()
        {
            return "*****Profile*****\n" + "Username: " + this.UserName + "\nBirth Date: " + this.BirthDate + "\nSex: " + this.Sex + "\nNationality: " + this.Nationality + "\nEmail: " + this.Email;
        }

    }
}