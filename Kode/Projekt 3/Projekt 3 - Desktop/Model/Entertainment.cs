using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3___Desktop.Model
{
    public class Entertainment
    {
        public int Genre { get; set; }
        public string Title { get; set; }
        public int Country { get; set; }
        public int Language { get; set; }
        public DateTime ReleasDate { get; set; }
        public string Storyline { get; set; }
        public int FilmingLocation { get; set; }
        public string Information { get; set; }
        public bool IsMovie { get; set; }

        public Entertainment()
        {

        }

        public Entertainment(int genre, string title, int country, int language, DateTime releaseDate, string storyline, int filmingLocation, string information)
        {
            this.Genre = genre;
            this.Title = title;
            this.Country = country;
            this.Language = language;
            this.ReleasDate = releaseDate;
            this.Storyline = storyline;
            this.FilmingLocation = filmingLocation;
            this.Information = information;
        }
    }
}
