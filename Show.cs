using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class Show
    {
        // This class will hold information of the set of shows that the
        // audience want to rate or might be a guide if a show is a
        // interesting or not.
        public string Title { get; private set; }
        public string Director { get; private set; }
        public string MainCast { get; private set; }
        public DateTime ShowRelease { get; private set; }
        public ShowType ShowType { get; private set; }
        public ShowGenre ShowGenre { get; private set; }
        public ShowClassification ShowClassification { get; private set; }// (G, PG, R, NP)
        public double AudienceRating { get; private set; }
        public float AdministratorRating { get; private set; }
        

        public Show(string title, string director, string mainCast, DateTime showRelease, ShowType showType, ShowGenre showGenre, ShowClassification showClassification)
        {
            this.Title = title;
            this.Director = director;
            this.MainCast = mainCast;
            this.ShowRelease = showRelease;
            this.ShowType = showType;
            this.ShowGenre = showGenre;
            this.ShowClassification = showClassification;
            this.AudienceRating = 0.0f;
            this.AdministratorRating = 0.0f;
        }
        public Show(Show s, double audienceRating)
        {
            // Constructor when the audience will rate the show
            // My method in building this constructor is unnecessary still needs improvements.
            this.Title = s.Title;
            this.Director = s.Director;
            this.MainCast = s.MainCast;
            this.ShowRelease = s.ShowRelease;
            this.ShowType = s.ShowType;
            this.ShowGenre = s.ShowGenre;
            this.ShowClassification = s.ShowClassification;
            this.AudienceRating = audienceRating;
            this.AdministratorRating = s.AdministratorRating;
        }

        public Show(Show sh, float administratorRating)
        {
            // Constructor when the administrator will rate the show
            // My method in building this constructor is unnecessary still needs improvements.
            // Since I can't make two constructors with the same parameters,
            // I just change the data type to float.
            this.Title = sh.Title;
            this.Director = sh.Director;
            this.MainCast = sh.MainCast;
            this.ShowRelease = sh.ShowRelease;
            this.ShowType = sh.ShowType;
            this.ShowGenre = sh.ShowGenre;
            this.ShowClassification = sh.ShowClassification;
            this.AudienceRating = sh.AudienceRating;
            this.AdministratorRating = administratorRating;
        }

    }
}
