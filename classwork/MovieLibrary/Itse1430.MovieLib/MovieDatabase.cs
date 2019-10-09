using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>
    /// Manages the movies in a database.
    /// </summary>
    public class MovieDatabase
    {
        public Movie Add ( Movie movie )
        {
            // List Code
            movie.Id = ++_id;
            _movies.Add(movie);

            return movie;

            #region Array Code
            //// Add to array
            //for (var index = 0; index < _movies.Count; ++index)
            //{
            //    if (_movies[index] == null)
            //    {
            //        _movies[index] = movie;
            //        return;
            //    };
            //};
            #endregion
        }

        public void Remove ( int id )
        {
            // List Code
            var movie = FindMovie(id);
            if (movie != null)
                _movies.Remove(movie);

            #region Array Code
            //// Remove from array
            //for( var index = 0; index < _movies.Count; ++index)
            //{
            //    // This won't work
            //    if (_movies[index].Equals(movie))
            //    {
            //        _movies[index] = null;
            //        return;
            //    };
            //};
            #endregion
        }

        public Movie Get ( int id )
        {
            return FindMovie(id);
        }

        public Movie[] GetAll()
        {
            #region Array Code
            //// Filter out empty movies
            //var count = 0;
            //foreach (var movie in _movies)
            //    if (movie != null)
            //        ++count;
            #endregion

            // List Code
            var index = 0;
            var movies = new Movie[_movies.Count];
            foreach (var movie in _movies)
                if (movie != null)
                    movies[index++] = movie;

            return movies;
        }

        public void Update ( int id, Movie newMovie )
        {
            var existing = FindMovie(id);
            if (existing == null)
                return; // TODO: Error

            // Update existing movie
            existing.Description = newMovie.Description;
            existing.HaveSeen = newMovie.HaveSeen;
            existing.Rating = newMovie.Rating;
            existing.ReleaseYear = newMovie.ReleaseYear;
            existing.RunLength = newMovie.RunLength;
            existing.Title = newMovie.Title;
        }

        private Movie FindMovie (int id )
        {
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }

        private List<Movie> _movies = new List<Movie>();

        private int _id = 0;
    }
}
