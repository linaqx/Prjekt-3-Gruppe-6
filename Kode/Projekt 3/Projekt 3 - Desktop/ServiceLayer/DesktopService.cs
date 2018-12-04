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
            ServiceReference1.EntertainmentServiceClient gSC = new ServiceReference1.EntertainmentServiceClient();
            

            var genre = gSC.FindAllGenre();

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
