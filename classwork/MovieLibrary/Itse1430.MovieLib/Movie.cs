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

        /// <summary>
        /// Validates the movie.
        /// </summary>
        /// <returns>An error message if validation fails or empty string otherwise.</returns>
        public string Validate()
        {
            // Name is required
            if (String.IsNullOrEmpty (title))
                return "Title is required";

            // Release year >= 1900
            if (releaseYear < 1900)
                return "Release Year must be >= 1900";
            // Run Length >= 0
            if (runLength < 0)
                return "Run Length must be >= 0";

            // Rating is required
            if (String.IsNullOrEmpty (rating))
                return "Rating is required";

            return "";
        }

        // Can new up other objects
        //private Movie originalMovie = new Movie ();
    }
}
