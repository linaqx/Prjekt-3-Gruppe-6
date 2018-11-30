using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3___Desktop.Controller
{
    interface DesktopControllerIF
    {
        //ReturnAllEntertainments();

        //ReturnEntertainmentBySearch();

         void InsertMovieIntoEntertainment(string title, int genre, int country, int language, DateTime releaseDate, string storyline, int filmingLocation, string information);
    }
}
