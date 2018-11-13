using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_3___WCF.Model
{
    public class Series : Entertainment
    {
        public Series(string genre, string title, string country, string language, DateTime releaseDate, string storyline, string filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {

        }
    }
}