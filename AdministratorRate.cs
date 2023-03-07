using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class AdministratorRate
    {
        // This class purpose is to get the rating of the administrator towards the show.
        // Sir Recommendation
        public Administrator Admin { get; private set; }
        public Show Show { get; private set; }

        public AdministratorRate(Administrator admin, Show show)
        {
            this.Admin = admin;
            this.Show = show;
        }

        public double GetAdminRate()
        {
            // This function will return a double value depends on the administrator position
            // Return 10% if the position is in the bottom, 15% if in
            // middle, and 20% if top),

            double num = 0.0D;

            if (Admin.Position == AdminPosition.Top)
               num = 0.2D;
            else if (Admin.Position == AdminPosition.Middle)
               num = 0.15D;
            else if (Admin.Position == AdminPosition.Bottom)
               num =  0.1f;

            Show.NumOfPeopleRated++;// number of people that rated the show will be increment

            return num;
        }

        
    }
}
