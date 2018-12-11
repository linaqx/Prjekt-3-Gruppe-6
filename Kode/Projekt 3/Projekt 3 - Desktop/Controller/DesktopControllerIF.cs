using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___Desktop.Model;

namespace Projekt_3___Desktop.Controller
{
    interface DesktopControllerIF
    {
        //ReturnAllEntertainments();

        //ReturnEntertainmentBySearch();

         void InsertMovieIntoEntertainment(Genre genre, string title, Country country, Language language, DateTime releaseDate, string storyline, string filmingLocation, string information, bool isMovie);
    }
}
