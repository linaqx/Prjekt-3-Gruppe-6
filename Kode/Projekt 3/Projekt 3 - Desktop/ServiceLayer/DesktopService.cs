using Projekt_3___Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Projekt_3___Desktop.ServiceReference1;

namespace Projekt_3___Desktop.ServiceLayer
{
    class DesktopService : DesktopServiceIF
    {
        private EntertainmentAdminService.EntertainmentAdminServiceClient easc;

        public DesktopService()
        {
            easc = new EntertainmentAdminService.EntertainmentAdminServiceClient();
        }

        public void InsertMovieIntoEntertainment(Movie m)
        {
            EntertainmentAdminService.Movie movie = ConvertToMovie(m);
            easc.StartInsertMovieTransaction(movie);
        }

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


        public List<Genre> GetGenre()
        {

            var genre = easc.FindAllGenre();

            List<Genre> convertedGenre = ConvertToGenre(genre);

            return convertedGenre;
        }

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

        public List<Country> GetCountry()
        {

            var country = easc.FindAllCountries();

            List<Country> convertedCountry = ConvertToCountry(country);

            return convertedCountry;
        }

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

        public List<Language> GetLanguage()
        {
            var language = easc.FindAllLanguage();

            List<Language> convertedLanguage = ConvertToLanguage(language);

            return convertedLanguage;
        }

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

        //public List<FilmingLocation> GetFilmingLocation()
        //{
        //    var film = easc.FindAllFilmingLocations();

        //    List<FilmingLocation> convertedFilm = ConvertToFilmingLocation(film);

        //    return convertedFilm;
        //}

        //private List<FilmingLocation> ConvertToFilmingLocation(EntertainmentAdminService.FilmingLocation[] serviceFilmingLocation)
        //{
        //    FilmingLocation temp = null;
        //    List<FilmingLocation> convertedFilm = new List<FilmingLocation>();


        //    foreach (EntertainmentAdminService.FilmingLocation oldFilmingLocation in serviceFilmingLocation)
        //    {
        //        temp = new FilmingLocation()
        //        {
        //            Id = oldFilmingLocation.Id,
        //            Name = oldFilmingLocation.Name
        //        };

        //        convertedFilm.Add(temp);
        //    }

        //    return convertedFilm;
        //}
    }
}
