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
        public int genre { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public int country { get; set; }
        [DataMember]
        public int language { get; set; }
        [DataMember]
        public DateTime releaseDate { get; set; }
        [DataMember]
        public string storyline { get; set; }
        [DataMember]
        public int filmingLocation { get; set; }
        [DataMember]
        public string information { get; set; }
        
        public Movie(int genre, string title, int country, int language, DateTime releaseDate, string storyline, int filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
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