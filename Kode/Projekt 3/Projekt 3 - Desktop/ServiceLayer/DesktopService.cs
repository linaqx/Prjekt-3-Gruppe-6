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

        public List<Projekt_3___Desktop.Model.Genre> GetGenre()
        {
            ServiceReference1.EntertainmentServiceClient gSC = new ServiceReference1.EntertainmentServiceClient();

            var genre = gSC.FindAllGenre();

            List<Projekt_3___Desktop.Model.Genre> convertedGenre = ConvertToGenre(genre);

            return convertedGenre;
        }

        private List<Projekt_3___Desktop.Model.Genre> ConvertToGenre(Projekt_3___Desktop.ServiceReference1.Genre[] serviceGenre)
        {
            Projekt_3___Desktop.Model.Genre temp = null;
            List<Projekt_3___Desktop.Model.Genre> convertedGenre = new List<Projekt_3___Desktop.Model.Genre>();


            foreach (Projekt_3___Desktop.ServiceReference1.Genre oldGenre in serviceGenre)
            {
                temp = new Model.Genre()
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
