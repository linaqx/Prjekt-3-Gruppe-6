using Projekt_3___Desktop.Model;
using Projekt_3___Desktop.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3___Desktop.Controller
{
    class DesktopController : DesktopControllerIF
    {
        private DesktopService DesktopService;


        public DesktopController()
        {
            DesktopService = new DesktopService();
        }

        public void InsertMovieIntoEntertainment(int genre, string title, int country, int language, DateTime releaseDate, string storyline, string filmingLocation, string information, bool isMovie)
        {
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



        public List<Genre> GetGenre()
        {
            return DesktopService.GetGenre();
        }

        public List<Country> GetCountry()
        {
            return DesktopService.GetCountry();
        }

        public List<Language> GetLanguage()
        {
            return DesktopService.GetLanguage();
        }

        //public List<FilmingLocation> GetFilmingLocation()
        //{
        //    return DesktopService.GetFilmingLocation();
        //}

    }

    //public list<Entertainment> ReturnAllEntertainments()
    //{
    //    //kald WCF solution.Projekt 3 - WCF. EntertainmentController.FindAllEntertainments();
    //    DesktopService.ReturnAllEntertainments();
    //    return null;
    //}

    //public list<Entertainment> ReturnEntertainmentBySearch()
    //{
    //    return null;
    //}


}
