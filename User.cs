using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShowListing
{
    public abstract class User
    {
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public char Sex { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Password;


        public User(string username, DateTime birthdate, char sex, string nationality, string email, string password)
        {
            this.UserName = username;
            this.BirthDate = birthdate;
            this.Sex = sex;
            this.Nationality = nationality;
            this.Email = email;
            Password = password;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidPassword(string password)
        {
            // Password must be at least 8 characters long
            // Password must contain at least one uppercase letter
            // Password must contain at least one lowercase letter
            // Password must contain at least one digit
            // Password must contain at least one special character

            if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

        //public abstract double VoteShow();

    }
}