using System;
using System.Collections.Generic;
using System.Linq;

namespace Itse1430.MovieLib
{
    /// <summary> Manages the movies in a database. </summary>
    public abstract class MovieDatabase : IMovieDatabase
    {
        public Movie Add ( Movie movie )
        {
            // List Code
            if (movie == null)
                return null;

            //var context = new ValidationContext(movie);
            //var results = movie.Validate(context);
            var results = ObjectValidator.TryValidateObject(movie);
            if (results.Count() > 0)
                return null;

            // Name must be unique
            var exisiting = GetByNameCore(movie.Title);
            if (exisiting != null)
                return null;

            return AddCore(movie);
        }

        public void Remove ( int id )
        {
            //TODO: Validate id
            RemoveCore(id);
        }

        public Movie Get ( int id )
        {
            //TODO: Validate
            if (id <= 0)
                return null;

            return GetCore(id);
        }

        public IEnumerable<Movie> GetAll ()
        {
            return GetAllCore();
        }

        public void Update ( int id, Movie newMovie )
        {
            // Validate
            if (id <= 0)
                return;
            if (newMovie == null)
                return;

            // if(!String.IsNullOrEmpty(movie.Validate()))
            //var context = new ValidationContext(newMovie);
            //var results = newMovie.Validate(context);
            var results = ObjectValidator.TryValidateObject(newMovie);
            if (results.Count() > 0)
                return;

            // Must be unique
            var existing = GetByNameCore(newMovie.Title);
            if (existing != null && existing.Id != id)
                return;

            UpdateCore(id, newMovie);
        }

        protected abstract Movie AddCore ( Movie movie );

        protected abstract void RemoveCore ( int id );

        protected abstract Movie GetCore ( int id );

        protected abstract IEnumerable<Movie> GetAllCore ();

        protected abstract Movie UpdateCore ( int id, Movie newMovie );

        protected abstract Movie GetByNameCore ( string name );
    }
}
