using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_3___WCF.Model
{
    public class Series : Entertainment
    {


        public Series(int genre, string title, int country, int language, DateTime releaseDate, string storyline, int filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {

        }
    }
}