﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Itse1430.MovieLib.WebHost.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        [RequiredAttribute(AllowEmptyStrings = false)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Rating { get; set; }

        [Display(Name = "Release Year")]
        [Range(1900, Int32.MaxValue, ErrorMessage = "Release year must be >= 1900")]
        public int ReleaseYear { get; set; } = 1900;

        [RangeAttribute(0, Int32.MaxValue, ErrorMessage = "Run length must be >= 0")]
        public int RunLength { get; set; }

        public bool HaveSeen { get; set; }
    }
}