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
    public class Entertainment
    {
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public Country Country { get; set; }
        public Language Language { get; set; }
        public DateTime ReleasDate { get; set; }
        public string Storyline { get; set; }
        public string FilmingLocation { get; set; }
        public string Information { get; set; }
        public bool IsMovie { get; set; }

        /// <summary>
        /// Constructor for Entertainment
        /// </summary>
        public Entertainment()
        {

        }

        /// <summary>
        /// Constructor for Entertainment with parameters
        /// </summary>
        /// <param name="genre"></param>
        /// <param name="title"></param>
        /// <param name="country"></param>
        /// <param name="language"></param>
        /// <param name="releaseDate"></param>
        /// <param name="storyline"></param>
        /// <param name="filmingLocation"></param>
        /// <param name="information"></param>
        public Entertainment(Genre genre, string title, Country country, Language language, DateTime releaseDate, string storyline, string filmingLocation, string information)
        {
            this.Genre = genre;
            this.Title = title;
            this.Country = country;
            this.Language = language;
            this.ReleasDate = releaseDate;
            this.Storyline = storyline;
            this.FilmingLocation = filmingLocation;
            this.Information = information;
        }
    }
}
