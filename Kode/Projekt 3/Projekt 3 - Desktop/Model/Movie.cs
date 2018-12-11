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

        public Movie(Genre genre, string title, Country country, Language language, DateTime releaseDate, string storyline, string filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {
            
        }
    }
}
