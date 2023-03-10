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
            /* APPLICATION NAME - SHOW METER APPLICATION
              - These application is show listing app used to rate different kind of shows, includes Movies, Theatre, TV Series, Reality Shows, based on the  users perspective towards the show. It will serve as the world’s most trusted recommendation resources for quality entertainment. 
                
              - If they are curious towards a certain show, they might wanna use this application to see if it is worth to watch or not.

              - Since it is show listing application , ongoing and upcoming movies can be searched in this application.

              - The ratings of the show is categorized into two, the Administrator Rating and Audience Rating. (Definition is presented in the said classes.)
                
              - Some of the classes is still not well structured.

              - The two functions of the Main Program which defined above has it's corresponding purpose when you log in an account.

              - Implementation of the object in the main program will be process soon.
            */

            // Making sample objects for experiment
            Show s1 = new("Avengers", "Ryan Fide", "Chris Evans Robert Downey Jr",  new DateTime(2019, 4, 21), ShowType.Movie, ShowGenre.Action, ShowClassification.PG);

            Console.WriteLine(s1);

            Audience a1 = new("buggernut04", new DateTime(2002, 10, 4), 'M', "Filipino", "21-1-00193@vsu.edu.ph", "sup_1004");

            Console.WriteLine("\n" + a1);
        }


    }
}