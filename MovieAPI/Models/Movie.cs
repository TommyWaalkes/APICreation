using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int RunMinutes { get; set; }
        public Genre Genre { get; set; }

        public Movie()
        {

        }

        public Movie(int iD, string title, int runMinutes, Genre genre)
        {
            ID = iD;
            Title = title;
            RunMinutes = runMinutes;
            Genre = genre;
        }
    }

    public class MovieContext : DbContext
    {
        DbSet<Movie> movies { get; set; }

        public System.Data.Entity.DbSet<MovieAPI.Models.Movie> Movies { get; set; }
    }
}