using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>
    /// Represents movie data.
    /// </summary>
    public class Movie
    {
        // Fields - data to be stored
        // TODO: Never make fields public!!
        public string title = "";
        public string description = "";
        public int releaseYear = 1900;
        public string rating = "";
        public bool haveSeen;
        public int runLength;

        // Can new up other objects
        //private Movie originalMovie = new Movie ();
    }
}
