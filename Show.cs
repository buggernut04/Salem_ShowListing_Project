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

        public int NumOfPeopleRated { get; set; }
        

        public Show(string title, string director, string mainCast, DateTime showRelease, ShowType showType, ShowGenre showGenre, ShowClassification showClassification)
        {
            this.Title = title;
            this.Director = director;
            this.MainCast = mainCast;
            this.ShowRelease = showRelease;
            this.ShowType = showType;
            this.ShowGenre = showGenre;
            this.ShowClassification = showClassification;
            this.NumOfPeopleRated = 0;
        }

        public override string ToString()
        {
            return "*****SHOW DESCRIPTION*****" + "\nTitle: " + this.Title + "\nDirector: " + this.Director + "\nMain Cast/s: " + this.MainCast + "\nRelease Date: " + this.ShowRelease + "\nShow Type: " + this.ShowType + "\nShow Genre: " + this.ShowGenre + "\nShow Classification: " + this.ShowClassification + "\nNumber of People Rated: " + this.NumOfPeopleRated;
        }
    }
}
