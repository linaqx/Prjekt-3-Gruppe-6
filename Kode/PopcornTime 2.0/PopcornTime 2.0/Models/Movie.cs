using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornTime_2._0.Models
{
    public class Movie : Entertainment
    {

        public Movie()
        {

        }

        public Movie(int id, Genre genre, string title, Country country, Language language, DateTime releaseDate, string storyLine, string filmingLocation, string information) : base(id, genre, title, country, language, releaseDate, storyLine, filmingLocation, information)
        {
        

        }
    }
}