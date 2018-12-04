using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3___Desktop.Model
{
    public class Movie : Entertainment
    {
        public Movie() : base()
        {

        }

        public Movie(int genre, string title, int country, int language, DateTime releaseDate, string storyline, int filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {
            
        }
    }
}
