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
        /// <summary> Gets or sets the title. </summary>
        public string Title
        {
            // null coalescing
            // !String.IsNullOrEmpty(_title) ? _title: ""
            get { return _title ?? ""; }
            set { _title = value; }
        }

        /// <summary> Gets or sets the description. </summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        /// <summary> Gets or sets the rating. </summary>
        public string Rating
        {
            get { return _rating ?? ""; }
            set { _rating = value; }
        }

        /// <summary> Gets or sets the release year. </summary>
        public int ReleaseYear { get; set; } = 1900; // Auto property
        // Full property
        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}

        /// <summary> Gets or sets the run length. </summary>
        public int RunLength { get; set; }
        //public int RunLength
        //{
        //    get { return _runLength; }
        //    set { _runLength = value; }
        //}

        /// <summary> Gets or sets if user has seen the movie. </summary>
        public bool HaveSeen { get; set; }
        //public bool HaveSeen
        //{
        //    get { return _haveSeen; }
        //    set { _haveSeen = value; }
        //}

        // Value is 1939, read only, public
        //public int ReleaseYearForColor { get; } = 1939;
        // private readonly int _releaseYearForColor = 1939;

        // Constant field
        public const int ReleaseYearForColor = 1939;
        // public readonly int ReleaseYearForColor = 1939;
        public bool IsBlackAndWhite
        {
            get { return ReleaseYear <= ReleaseYearForColor; }
            // set { }
        }

        public string TestAccessibility
        {
            get { return ""; }
            private set { }
        }

        // Fields - data to be stored
        // TODO: Never make fields public!!
        private string _title = "";
        private string _description = "";
        // private int _releaseYear = 1900;
        private string _rating = "";
        // private bool _haveSeen;
        // private int _runLength;

        /// <summary>
        /// Validates the movie.
        /// </summary>
        /// <returns>An error message if validation fails or empty string otherwise.</returns>
        public string Validate()
        {
            // Name is required
            if (String.IsNullOrEmpty (Title))
                return "Title is required";

            // Release year >= 1900
            if (ReleaseYear < 1900)
                return "Release Year must be >= 1900";
            // Run Length >= 0
            if (RunLength < 0)
                return "Run Length must be >= 0";

            // Rating is required
            if (String.IsNullOrEmpty (Rating))
                return "Rating is required";

            return "";
        }

        // Can new up other objects
        //private Movie originalMovie = new Movie ();
    }
}
