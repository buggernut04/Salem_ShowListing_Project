using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class Audience : User
    {
        public Audience(string username, DateTime birthdate, char sex, string nationality, string email, string password) : base(username, birthdate, sex, nationality, email, password)
        {
        
        }
    }
}