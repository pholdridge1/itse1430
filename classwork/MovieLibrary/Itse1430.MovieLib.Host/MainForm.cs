﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Itse1430.MovieLib.IO;
using Itse1430.MovieLib.SqlServer;

namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            // Seed movies
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];
            // _movies = new FileMovieDatabase(@"movies.csv");
            _movies = new SqlMovieDatabase(connString.ConnectionString);
            //var count = _movies.GetAll().Count();
            //if (count == 0)
            //    _movies.Seed();

            UpdateUI();
        }

        //Called when Movie\Add selected
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();

            //Modeless - does not block main window
            //form.Show();

            //Show the new movie form modally
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _movies.Add(form.Movie);
                    UpdateUI();
                } catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    MessageBox.Show("Save failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // throw;      // Rethrow existing exception
                    // throw ex;   // Throwing a new exception
                }
            }
        }

        private Movie GetSelectedMovie ()
        {
            var item = _lstMovies.SelectedItem;
            //if (item == null)
            //    return null;

            //Movie or null
            return item as Movie;

            //_lstMovies.SelectedItems.OfType<Movie>();

            #region Typecasting Demo
            ////Other approaches
            ////C-style cast
            //(Movie)item;

            ////Old approach 1
            //var tempVar = item as Movie;
            //if (tempVar != null)
            //{
            //};

            ////Old approach 2
            //if (item is Movie)
            //{
            //    var i = (Movie)item;
            //    //Do something with movie
            //}

            ////Pattern matching
            //if (item is Movie movie)
            //{
            //};
            #endregion
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            var form = new MovieForm ();
            form.Movie = movie;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _movies.Update(movie.Id, form.Movie);
                UpdateUI();
            }
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //// Demo
            //var menuItem = sender as Button;
            //// This will crash if menuItem is null
            //// var text = menuItem.Text;

            //// Handle null - as statement
            //var text = "";
            //if (menuItem != null)
            //    text = menuItem.Text;
            //else
            //    text = "";

            //// As expression
            //var text2 = (menuItem != null) ? menuItem.Text : "";

            //// Null coalescing menuItem ?? "";
            //// Null conditional operator
            //var text3 = menuItem?.Text ?? "";

            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            //Confirmation
            var msg = $"Are you sure you want to delete {movie.Title}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            // Delete it
            _movies.Remove(movie.Id);
            UpdateUI();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        //private string OrderByTitle ( Movie movie )
        //{
        //    return movie.Title;
        //}

        //private int OrderByReleaseYear ( Movie movie )
        //{
        //    return movie.ReleaseYear;
        //}

        private void UpdateUI ()
        {
            var movies = from m in _movies.GetAll()
                         orderby m.Title, m.ReleaseYear
                         select m;

            //var movies = _movies.GetAll()
            //                    .OrderBy(m => m.Title)
            //                    .ThenBy(m => m.ReleaseYear);
            //.OrderBy(OrderByTitle)
            //.ThenBy(OrderByReleaseYear);

            PlayWithEnumerable(movies);

            // Programmatic approach
            //_lstMovies.Items.Clear();
            //_lstMovies.Items.AddRange(movies);

            // For more complex bindings

            _lstMovies.DataSource = movies.ToArray();
        }

        private void PlayWithEnumerable ( IEnumerable<Movie> movies )
        {
            Movie firstOne = movies.FirstOrDefault();
            Movie lastOne = movies.LastOrDefault();
            //Movie onlyOne = movies.SingleOrDefault();

            //var coolMovies = movies.Where(m => m.ReleaseYear > 1979 
            //                                && m.ReleaseYear < 2000);
            int id = 1;
            var otherMovies = movies.Where(m => m.Id > ++id);
            //var temp1 = new NestedType { id = id };
            //var otherMovies = movies.Where(temp1.WhereCondition);
            //var lastId = id;
        }

        //private sealed class NestedType
        //{
        //    public int id { get; set; }
        //    public bool WhereCondition ( Movie m )
        //    {
        //        return m.Id > ++id;
        //    }
        //}

        // private Movie[] _movies = new Movie[100];
        private IMovieDatabase _movies;
    }
}