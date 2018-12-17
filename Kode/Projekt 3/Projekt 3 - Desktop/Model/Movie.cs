using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___Desktop.Model
{
    public class Movie : Entertainment
    {
        /// <summary>
        /// Constructor for Movie
        /// </summary>
        public Movie() : base()
        {

        }

        /// <summary>
        /// Constructor for Movie with parameters
        /// </summary>
        /// <param name="genre"></param>
        /// <param name="title"></param>
        /// <param name="country"></param>
        /// <param name="language"></param>
        /// <param name="releaseDate"></param>
        /// <param name="storyline"></param>
        /// <param name="filmingLocation"></param>
        /// <param name="information"></param>
        public Movie(Genre genre, string title, Country country, Language language, DateTime releaseDate, string storyline, string filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {
            
        }
    }
}
