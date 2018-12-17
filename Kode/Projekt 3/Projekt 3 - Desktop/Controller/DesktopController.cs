using Projekt_3___Desktop.Model;
using Projekt_3___Desktop.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___Desktop.Controller
{
    class DesktopController : DesktopControllerIF
    {
        private DesktopService DesktopService;

        /// <summary>
        /// Constructor for DesktopController
        /// </summary>
        public DesktopController()
        {
            DesktopService = new DesktopService();
        }

        /// <summary>
        /// Inserts a movie ento Entertainment list
        /// </summary>
        /// <param name="genre_id"></param>
        /// <param name="genre_name"></param>
        /// <param name="title"></param>
        /// <param name="country_id"></param>
        /// <param name="country_name"></param>
        /// <param name="language_id"></param>
        /// <param name="language_name"></param>
        /// <param name="releaseDate"></param>
        /// <param name="storyline"></param>
        /// <param name="filmingLocation"></param>
        /// <param name="information"></param>
        /// <param name="isMovie"></param>
        public void InsertMovieIntoEntertainment(int genre_id, string genre_name, string title, int country_id, string country_name, int language_id, string language_name, DateTime releaseDate, string storyline, string filmingLocation, string information, bool isMovie)
        {
            Genre genre = new Genre
            {
                Id = genre_id,
                Name = genre_name
            };

            Country country = new Country
            {
                Id = country_id,
                Name = country_name
            };

            Language language = new Language
            {
                Id = language_id,
                Name = language_name
            };

            Movie m = new Movie
            {
                Title = title,
                Genre = genre,
                Country = country,
                Language = language,
                ReleasDate = releaseDate,
                Storyline = storyline,
                FilmingLocation = filmingLocation,
                Information = information,
                IsMovie = isMovie
            };

            DesktopService.InsertMovieIntoEntertainment(m);
        }

        /// <summary>
        /// Gets genre list from database
        /// </summary>
        /// <returns>List<Genre></Genre></returns>
        public List<Genre> GetGenre()
        {
            return DesktopService.GetGenre();
        }

        /// <summary>
        /// Gets country list from database
        /// </summary>
        /// <returns>List<Country> </returns>
        public List<Country> GetCountry()
        {
            return DesktopService.GetCountry();
        }

        /// <summary>
        /// Get language list from database
        /// </summary>
        /// <returns>List<Language> </Language></returns>
        public List<Language> GetLanguage()
        {
            return DesktopService.GetLanguage();
        }
    }
}
