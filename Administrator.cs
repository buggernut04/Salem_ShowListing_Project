using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class Administrator : User
    {   
        // This class is inheriting the User class since Administrator is a
        // user of the Applicaton.

        // Administrator serve as a proffesional in the field of reviewing a specific show. Requirements are needed to be an administrator of this application.

        // Their interest with the movie is very important if you're an
        // audience.
        
        public AdminPosition Position { get; private set; } // Top, Middle, Low

        public Administrator(string username, DateTime birthdate, char gender, string nationality, string email, string password ,AdminPosition adminPos) : base(username, birthdate, gender, nationality, email, password)
        {
            this.Position = adminPos;
        }

        public static bool IsAdministratorKey(int key)
        {
            // If a user will log in as an administrator.
            // 1442 - Low/Bottom Position
            // 2134 - Middle Position
            // 4156 - High Position
            // Keys generated was based on chat gpt that relates to some administrator example.
            if((key == 1442) || (key == 2134) || (key == 4156))
                return true;
            return false;
        }

        public static AdminPosition CodePositionVerifier(int code)
        {
            // If a certain user create an account to be an administrator.
            // Code to be inputted:
            // Low/Bottom Position: 212340 - position will be auto generated in the account
            // Middle Position: 372540 - position will be auto generated in the account
            // Top Position: 514323 - position will be auto generated in the account

            if(code == 212340)
                return AdminPosition.Bottom;
            else if(code == 372540)
                return AdminPosition.Middle;
            else if(code == 514323)
                return AdminPosition.Top;

            return AdminPosition.NotCredited;
        }
    }
}