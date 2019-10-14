using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary> Manages the movies in a database. </summary>
    public class MovieDatabase
    {
        public MovieDatabase ()
        {
            // Collection initializer
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = ++_id,
                    Title = "Jaws",
                    ReleaseYear = 1979,
                    Rating = "PG",
                },
                new Movie()
                {
                    Id = ++_id,
                    Title = "Jaws 2",
                    ReleaseYear = 1981,
                    Rating = "PG-13",
                },
                new Movie()
                {
                    Id = ++_id,
                    Title = "Wreck-It Ralph",
                    ReleaseYear = 2014,
                    Rating = "PG",
                }
        };
            //var movie = new Movie()
            //{
            //    Id = ++_id,
            //    Title = "Jaws",
            //    ReleaseYear = 1979,
            //    Rating = "PG",
            //};
            //// Add(movie);
            //_movies.Add(movie);

            //movie = new Movie()
            //{
            //    Id = ++_id,
            //    Title = "Jaws 2",
            //    ReleaseYear = 1981,
            //    Rating = "PG-13",
            //};
            //// Add(movie);
            //_movies.Add(movie);

            //movie = new Movie()
            //{
            //    Id = ++_id,
            //    Title = "Wreck-It Ralph",
            //    ReleaseYear = 2014,
            //    Rating = "PG",
            //};
            //// Add(movie);
            //_movies.Add(movie);
        }

        public Movie Add ( Movie movie )
        {
            // List Code
            if (movie == null)
                return null;
            if (!String.IsNullOrEmpty(movie.Validate()))
                return null;

            // Name must be unique
            var exisiting = FindMovie(movie.Title);
            if (exisiting != null)
                return null;

            //Add Movie
            movie.Id = ++_id;

            var newMovie = Clone(new Movie(), movie);
            _movies.Add(newMovie);

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
            //TODO: Validate
            if (id <= 0)
                return null;

            var movie = FindMovie(id);
            return movie != null ? Clone(new Movie(), movie) : null;
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
                    movies[index++] = Clone(new Movie(), movie);

            return movies;
        }

        public void Update ( int id, Movie newMovie )
        {
            // Validate
            if (id <= 0)
                return;
            if (newMovie == null)
                return;
            if (!String.IsNullOrEmpty(newMovie.Validate()))
                return;

            // Must be unique
            var existing = FindMovie(newMovie.Title);
            if (existing != null && existing.Id != id)
                return;

            existing = FindMovie(id);
            if (existing == null)
                return; // TODO: Error

            // Update existing movie
            newMovie.Id = id;
            Clone(existing, newMovie);
        }

        private Movie Clone ( Movie target, Movie source)
        {
            // Update existing movie
            target.Id = source.Id;
            target.Description = source.Description;
            target.HaveSeen = source.HaveSeen;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.RunLength = source.RunLength;
            target.Title = source.Title;

            return target;
        }

        private Movie FindMovie ( int id )
        {
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }

        private Movie FindMovie ( string name )
        {
            foreach (var movie in _movies)
                if (String.Compare(movie.Title, name, true) == 0)
                    return movie;

            return null;
        }

        private List<Movie> _movies = new List<Movie>();

        private int _id = 0;
    }
}
