using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class Movie : Entertainment
    {
        [DataMember]
        public string genre { get; set; }
        public string title { get; set; }
        public string country { get; set; }
        public string language { get; set; }
        public DateTime releaseDate { get; set; }
        public string storyline { get; set; }
        public string filmingLocation { get; set; }
        public string information { get; set; }
        
        public Movie(string genre, string title, string country, string language, DateTime releaseDate, string storyline, string filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {
            this.genre = genre;
            this.title = title;
            this.country = country;
            this.language = language;
            this.releaseDate = releaseDate;
            this.storyline = storyline;
            this.filmingLocation = filmingLocation;
            this.information = information;
        }

        public Movie()
        {

        }
    }
}