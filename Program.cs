using System.Collections;

namespace ShowListing
{
    public class Program
    {
        public bool IsAudienceExistingAcc(string email, string password, List<Audience> audience)
        {
            // If audience will log in.
            foreach(Audience i in audience)
            {
                if (i.Email == email && i.GetPassword == password)
                    return true;
            }
            
            return false;
        }

        public bool IsAdministratorExistingAcc(string email, string password, List<Administrator> admin)
        {
            // If administrator will log in.
            foreach (Administrator i in admin)
            {
                if (i.Email == email && i.GetPassword == password)
                    return true;
            }

            return false;
        }


        static void Main(string[] args)
        {
            Audience[] audience = new Audience[5];
            audience[0] = new Audience("buggernut", new DateTime(2002, 4, 10), 'M', "Filipino", "salemmichaelcyegmail.com", "Gwapoko_123");

            Console.WriteLine(User.IsValidEmail(audience[0].Email));
            Console.WriteLine(audience[0].MaskedPassword());
            audience[0].SetNewPassword = "hey123";
            Console.WriteLine(audience[0].MaskedPassword());
        }


    }
}