using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_3___WCF.Model
{
    public class Entertainment
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string StoryLine { get; set; }
        public string FilmingLocation { get; set; }
        public string Information { get; set; }

        public Entertainment(string genre, string title, string country, string language, DateTime realeaseDate, string storyLine, string filmingLocation, string information)
        {
            this.Genre = genre;
            this.Title = title;
            this.Country = country;
            this.Language = language;
            this.ReleaseDate = realeaseDate;
            this.StoryLine = storyLine;
            this.FilmingLocation = filmingLocation;
            this.Information = information;

        }

        public Entertainment()
        {

        }



        

        



    }
}