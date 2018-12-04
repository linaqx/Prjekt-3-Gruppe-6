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
        private ServiceReference1.EntertainmentServiceClient sC;

        public DesktopService()
        {
            sC = new ServiceReference1.EntertainmentServiceClient();
        }
    
        public void InsertMovieIntoEntertainment(Movie m)
        {
            
            
           // sC.StartInsertMovieTransaction(m);
        }

        public Movie CreateMovie()
        {
            Movie m = new Movie();
           
            return m;
        }

        public List<Genre> GetGenre()
        {
           
            var genre = sC.FindAllGenre();

            List<Genre> convertedGenre = ConvertToGenre(genre);

            return convertedGenre;
        }

        private List<Genre> ConvertToGenre(ServiceReference1.Genre[] serviceGenre)
        {
            Genre temp = null;
            List<Genre> convertedGenre = new List<Genre>();


            foreach (ServiceReference1.Genre oldGenre in serviceGenre)
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
           
            var country = sC.FindAllCountries();

            List<Country> convertedCountry = ConvertToCountry(country);

            return convertedCountry;
        }

        private List<Country> ConvertToCountry(ServiceReference1.Country[] serviceCountry)
        {
            Country temp = null;
            List<Country> convertedCountry = new List<Country>();


            foreach (ServiceReference1.Country oldCountry in serviceCountry)
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
            var language = sC.FindAllLanguage();

            List<Language> convertedLanguage = ConvertToLanguage(language);

            return convertedLanguage;
        }

        private List<Language> ConvertToLanguage(ServiceReference1.Language[] serviceLanguage)
        {
            Language temp = null;
            List<Language> convertedLanguage = new List<Language>();


            foreach (ServiceReference1.Language oldLanguage in serviceLanguage)
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

        public List<FilmingLocation> GetFilmingLocation()
        {
            var film = sC.FindAllFilmingLocations();

            List<FilmingLocation> convertedFilm = ConvertToFilmingLocation(film);

            return convertedFilm;
        }

        private List<FilmingLocation> ConvertToFilmingLocation(ServiceReference1.FilmingLocation[] serviceFilmingLocation)
        {
            FilmingLocation temp = null;
            List<FilmingLocation> convertedFilm = new List<FilmingLocation>();


            foreach (ServiceReference1.FilmingLocation oldFilmingLocation in serviceFilmingLocation)
            {
                temp = new FilmingLocation()
                {
                    Id = oldFilmingLocation.Id,
                    Name = oldFilmingLocation.Name
                };
                
                convertedFilm.Add(temp);
            }

            return convertedFilm;
        }
    }
}
