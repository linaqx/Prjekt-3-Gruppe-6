using Projekt_3___Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3___Desktop.ServiceLayer
{
    class DesktopService : DesktopServiceIF
    {
        public void InsertMovieIntoEntertainment(Movie m)
        {
            ServiceReference1.EntertainmentServiceClient sC = new ServiceReference1.EntertainmentServiceClient();
            
           // sC.StartInsertMovieTransaction(m);
        }

        public Movie CreateMovie()
        {
            Movie m = new Movie();
           
            return m;
        }

        public List<Genre> GetGenre()
        {
            return null;
        }

        public List<Country> GetCountry()
        {
            return null;
        }

        public List<Language> GetLanguage()
        {
            return null;
        }

        public List<FilmingLocation> GetFilmingLocation()
        {
            return null;
        }
    }
}
