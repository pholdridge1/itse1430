﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLib.Host
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent ();
        }

        // Must be a property...
        public Movie Movie { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            // Call base type
            // OnLoad(e);
            base.OnLoad(e);

            if (Movie != null)
            {
               _txtName.Text = Movie.Title;
               _txtDescription.Text = Movie.Description;
               _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
               _txtRunLength.Text = Movie.RunLength.ToString ();
               cbRating.Text = Movie.Rating;
               chkHaveSeen.Checked = Movie.HaveSeen;
            };

            ValidateChildren();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            // Object initializer syntax
            var movie = new Movie()
            {
                Title = _txtName.Text,
                Description = _txtDescription.Text,
                ReleaseYear = GetAsInt32(_txtReleaseYear),
                RunLength = GetAsInt32(_txtRunLength),
                Rating = cbRating.Text,
                HaveSeen = chkHaveSeen.Checked,
            };
            //Validate
            var message = movie.Validate ();
            if (!String.IsNullOrEmpty (message))
            {
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };


            //TODO: Save it
            Movie = movie;

            DialogResult = DialogResult.OK;
            Close ();
        }

        private int GetAsInt32 ( TextBox control )
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }

        private void BtnCancel_Click ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            // Name is required
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError(control, "Name is required");
            }
            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingReleaseYear ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            // ReleaseYear > 1900
            var value = GetAsInt32(control);
            if (value < 1900)
            {
                e.Cancel = true;
                _errors.SetError(control, "Release year must be >= 1900");
            }
            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingRunLength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            // Run length > 0
            var value = GetAsInt32(control);
            if (value < 0)
            {
                e.Cancel = true;
                _errors.SetError(control, "Run length must be >=");
            }
            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingRating ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            // Text is required
            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError(control, "Rating is required");
            }
            else
            {
                _errors.SetError(control, "");
            }
        }
    }
}
