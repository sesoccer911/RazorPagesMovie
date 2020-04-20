﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } //primary key for the DB
        public string Title { get; set; }

        [Display(Name = "Release Date")] //cleaning up the presentation of the data
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")] //clearning up the presentation of the data, mapping the price value in the db
        public decimal Price { get; set; }
    }
}