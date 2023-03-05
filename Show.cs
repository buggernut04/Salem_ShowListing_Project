using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowListing
{
    public class Show
    {
        public string Title { get; private set; }
        public string Director { get; private set; }
        public string MainCast { get; private set; }
        public ShowType ShowType { get; private set; }
        public ShowGenre ShowGenre { get; private set; }
        public ShowRating ShowRating { get; private set; }

        public Show(string title, string director, string mainCast, ShowType showType, ShowGenre showGenre, ShowRating showRating)
        {
            this.Title = title;
            this.Director = director;
            this.MainCast = mainCast;
            this.ShowType = showType;
            this.ShowGenre = showGenre;
            this.ShowRating = showRating;
        }
    }
}
