using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class AudienceRate
    {
        // This class purpose is to get the rating of the audience towards the show.
        // Sir Recommendation
        public Audience Audience { get; private set; }
        public Show Show { get; private set; }

        public AudienceRate(Audience aud, Show show) 
        {
            this.Audience = aud;
            this.Show = show;
        }

        public double GetAudRate()
        {
            // Simply return the corresponding vote of the audience
            Show.NumOfPeopleRated++;

            return 0.05D;
        }
    }
}
