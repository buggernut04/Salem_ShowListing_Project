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

        // The attributes will be the list of audience and administrator from both the AudienceRate
        // and AdministratorRate Class

        // The rating will be computed in this class as well to get the actual
        // rating of the show.

        // Every methods that will be define has it's own functionality


        public List<AudienceRate> NumOfAudience;
        public List<AdministratorRate> NumOfAdministrator;
        
        public double AudienceRating { get; private set; }
        public double AdminRating { get; private set; }

        public ShowMeter(List<AudienceRate> numOfaudience)
        {
            this.NumOfAudience = numOfaudience;
            this.AudienceRating = 0.0;
        }

        public ShowMeter(List<AdministratorRate> numOfadministrator)
        {
            this.NumOfAdministrator = numOfadministrator;
            this.AdminRating = 0.0;
        }

        public void ComputeAvgAudienceRate()
        {
            // This function will compute the average audience rating percentage of the show
            // based on the audience interest towards the show.

            foreach(AudienceRate aud in NumOfAudience)
            {
                this.AudienceRating += aud.GetAudRate();
            }

            this.AudienceRating = (this.AudienceRating / NumOfAudience.Count) * 100;
        }

        public void ComputeAvgAdministratorRate()
        {
            // This function will compute average admnistrator rating percentage of the show
            // based on the administrator's interest towards the show.

            // Formula being used depends on what position the administrator
            // is (add 10% if the position is in the bottom, 15% if in
            // middle, and 20% if top).

            foreach (AdministratorRate admin in this.NumOfAdministrator)
                this.AdminRating += admin.GetAdminRate();

            this.AdminRating = (this.AdminRating / NumOfAdministrator.Count) *  100;
        }
    }
}