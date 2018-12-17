using Projekt_3___Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___Desktop.ServiceLayer
{
    class DesktopService : DesktopServiceIF
    {
        private EntertainmentAdminService.EntertainmentAdminServiceClient easc;

        /// <summary>
        /// Constructor for DesktopService
        /// </summary>
        public DesktopService()
        {
            easc = new EntertainmentAdminService.EntertainmentAdminServiceClient();
        }

        /// <summary>
        /// Inserts a movie into database through server
        /// </summary>
        /// <param name="m"></param>
        public void InsertMovieIntoEntertainment(Movie m)
        {
            EntertainmentAdminService.Movie movie = ConvertToMovie(m);
            easc.StartInsertMovieTransaction(movie);
        }

        /// <summary>
        /// Converts a Movie to a service movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns>EntertainmentAdminService.Movie </returns>
        private EntertainmentAdminService.Movie ConvertToMovie(Movie movie)
        {
            EntertainmentAdminService.Genre genre = new EntertainmentAdminService.Genre
            {
                Id = movie.Genre.Id,
                Name = movie.Genre.Name
            };

            EntertainmentAdminService.Country country = new EntertainmentAdminService.Country
            {
                Id = movie.Country.Id,
                Name = movie.Country.Name
            };

            EntertainmentAdminService.Language language = new EntertainmentAdminService.Language
            {
                Id = movie.Language.Id,
                Name = movie.Language.Name
            };

            EntertainmentAdminService.Movie temp = new EntertainmentAdminService.Movie
            {
                Title = movie.Title,
                Genre = genre,
                Country = country,
                Language = language,
                ReleaseDate = movie.ReleasDate,
                StoryLine = movie.Storyline,
                FilmingLocation = movie.FilmingLocation,
                Information = movie.Information
            };
            return temp;
        }

        /// <summary>
        /// Gets list of genre from database
        /// </summary>
        /// <returns>List<Genre></Genre></returns>
        public List<Genre> GetGenre()
        {
            var genre = easc.FindAllGenre();
            List<Genre> convertedGenre = ConvertToGenre(genre);
            return convertedGenre;
        }

        /// <summary>
        /// Converts list of service genre to model genre
        /// </summary>
        /// <param name="serviceGenre"></param>
        /// <returns>List<Genre></returns>
        private List<Genre> ConvertToGenre(EntertainmentAdminService.Genre[] serviceGenre)
        {
            Genre temp = null;
            List<Genre> convertedGenre = new List<Genre>();

            foreach (EntertainmentAdminService.Genre oldGenre in serviceGenre)
            {
                temp = new Genre()
                {
                    Id = oldGenre.Id,
                    Name = oldGenre.Name
                };
                convertedGenre.Add(temp);
            }
            return convertedGenre;
        }

        /// <summary>
        /// Gets a list of country from database
        /// </summary>
        /// <returns>List<Country> </returns>
        public List<Country> GetCountry()
        {
            var country = easc.FindAllCountries();
            List<Country> convertedCountry = ConvertToCountry(country);
            return convertedCountry;
        }

        /// <summary>
        /// Converts a liste of service country to model country
        /// </summary>
        /// <param name="serviceCountry"></param>
        /// <returns>List<Country></returns>
        private List<Country> ConvertToCountry(EntertainmentAdminService.Country[] serviceCountry)
        {
            Country temp = null;
            List<Country> convertedCountry = new List<Country>();

            foreach (EntertainmentAdminService.Country oldCountry in serviceCountry)
            {
                temp = new Country()
                {
                    Id = oldCountry.Id,
                    Name = oldCountry.Name
                };

                convertedCountry.Add(temp);
            }

            return convertedCountry;
        }

        /// <summary>
        /// Gets a list of language from database
        /// </summary>
        /// <returns></returns>
        public List<Language> GetLanguage()
        {
            var language = easc.FindAllLanguage();
            List<Language> convertedLanguage = ConvertToLanguage(language);
            return convertedLanguage;
        }

        /// <summary>
        /// Converts a list of service language to model language
        /// </summary>
        /// <param name="serviceLanguage"></param>
        /// <returns>List<Language></returns>
        private List<Language> ConvertToLanguage(EntertainmentAdminService.Language[] serviceLanguage)
        {
            Language temp = null;
            List<Language> convertedLanguage = new List<Language>();

            foreach (EntertainmentAdminService.Language oldLanguage in serviceLanguage)
            {
                temp = new Language()
                {
                    Id = oldLanguage.Id,
                    Name = oldLanguage.Name
                };

                convertedLanguage.Add(temp);
            }
            return convertedLanguage;
        }
    }
}
