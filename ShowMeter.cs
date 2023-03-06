using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class ShowMeter
    {
        // This class will serve as the main function of this Application
        // I separated  the class that that works as the
        // functioning of the application, though I can just simply put it as
        // a method in the user class, but for me, it is maybe better that
        // the function of the app has it's own class.

        // Every methods that will be define in this class have three
        // parameters; the first parameter is the user itself, second
        // parameter will be list of all the user of the application(list of
        // audience will be separated to the list of administrator), and the
        // third will be the show that they want to rate.

        public static Show AudienceRate(List<Audience> numOfAudience, Show show)
        {
            // This function will just simply set the ratings of the show
            // based on the audience interest towards the show.

            // Formula being used is to add 5% on the current show rating,
            // then divide it by the total number of audience, lastly
            // multiply it by 100 to get the percentage.

            // Will return an object

            double num = 0.05;
               
            Show s = new(show, ((show.AudienceRating + num) / numOfAudience.Count));

            return s;
        }

        public static Show AdminRate(Administrator admin, List<Administrator> numOfAdmin, Show show)
        {
            // This function will just simply set the ratings of the show
            // based on the administrator's interest towards the show.

            // The first parameter will be use to determine what
            // administrator position currently rating is.

            // Formula being used is to add 5 on the current show rating,
            // then divide it by the total number of audience, lastly
            // multiply it by 100 to get the percentage.

            // Will return an object

            float num = 0.0f;

            if (admin.Position == AdminPosition.Top)
                num = 0.2f;
            else if (admin.Position == AdminPosition.Middle)
                num = 0.15f;
            else if (admin.Position == AdminPosition.Bottom)
                num = 0.1f;

            Show s = new Show(show, (show.AdministratorRating + num) / numOfAdmin.Count);

            return s;
        }
    }
}
