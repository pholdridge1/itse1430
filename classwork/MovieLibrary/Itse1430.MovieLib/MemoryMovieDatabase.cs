﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itse1430.MovieLib
{
    /// <summary> Manages the movies in a database. </summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
        protected override Movie AddCore ( Movie movie )
        {
            // Add Movie
            movie.Id = ++_id;

            var newMovie = Clone(new Movie(), movie);
            _movies.Add(newMovie);

            return movie;
        }

        protected override void RemoveCore ( int id )
        {
            var movie = FindMovie(id);
            if (movie != null)
                _movies.Remove(movie);
        }

        protected override Movie GetCore ( int id )
        {
            var movie = FindMovie(id);

            return movie != null ? Clone(new Movie(), movie) : null;
        }

        protected override IEnumerable<Movie> GetAllCore ()
                    //=> _movies.Select(m => Clone(new Movie(), m));
        {
            // _movies.Where(m => m.Id > 0)
            //        .Select(m => Clone(new Movie(), m));

            // LINQ Syntax
            return from m in _movies
                   where m.Id > 0
                   select Clone(new Movie(), m);
            //return _movies.Select(m => Clone(new Movie(), m));

        //    //foreach (var movie in _movies)
        //    //    yield return Clone(new Movie(), movie);
        }

        protected override Movie UpdateCore ( int id, Movie newMovie )
        {
            var existing = FindMovie(id);
            if (existing == null)
                throw new IOException();

            // Update existing movie
            newMovie.Id = id;
            Clone(existing, newMovie);

            return newMovie;
        }

        private Movie Clone ( Movie target, Movie source )
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

        protected override Movie GetByNameCore ( string name )
        {
            return _movies.FirstOrDefault(m => String.Compare(m.Title, name, true) == 0);

            // LINQ syntax equivalent
            //return (from m in _movies
            //       where String.Compare(m.Title, name, true) == 0
            //       select m).FirstOrDefault();

            //return _movies.Where(m => String.Compare(m.Title, name, true) == 0).FirstOrDefault();

                   //foreach (var movie in _movies)
                   //    if (String.Compare(movie.Title, name, true) == 0)
                   //        return movie;
        }

        private List<Movie> _movies = new List<Movie>();
        private int _id = 0;
    }
}
