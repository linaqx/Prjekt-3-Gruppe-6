using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___Desktop.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___Desktop.Controller
{
    interface DesktopControllerIF
    {
         void InsertMovieIntoEntertainment(int genre_id, string genre_name, string title, int country_id, string country_name, int language_id, string language_name, DateTime releaseDate, string storyline, string filmingLocation, string information, bool isMovie);
    }
}
