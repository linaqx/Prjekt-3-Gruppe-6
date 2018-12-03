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
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string language { get; set; }
        [DataMember]
        public DateTime releaseDate { get; set; }
        [DataMember]
        public string storyline { get; set; }
        [DataMember]
        public string filmingLocation { get; set; }
        [DataMember]
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