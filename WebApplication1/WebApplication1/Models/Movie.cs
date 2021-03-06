﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
          
            public int ID { get; set; }
  
            public string Title { get; set; }

        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
     }
   

    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }

}