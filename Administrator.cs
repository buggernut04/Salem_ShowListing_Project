using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class Administrator : User
    {
        public int AdministratorKey;
        public AdminPosition Position { get; private set; } // Top, Middle, Low

        public Administrator(string name, DateTime birthdate, char gender, string nationality, string email, string password, int administrative, AdminPosition adminPos) : base(name, birthdate, gender, nationality, email, password)
        {
            this.AdministratorKey = administrative;
            this.Position = adminPos;
        }
    }
}