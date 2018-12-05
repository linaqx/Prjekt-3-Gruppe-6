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
        public int Genre { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Country { get; set; }
        [DataMember]
        public int Language { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
        [DataMember]
        public string Storyline { get; set; }
        [DataMember]
        public int FilmingLocation { get; set; }
        [DataMember]
        public string Information { get; set; }
        
        public Movie(int genre, string title, int country, int language, DateTime releaseDate, string storyline, int filmingLocation, string information) : base(genre, title, country, language, releaseDate, storyline, filmingLocation, information)
        {
            Genre = genre;
            Title = title;
            Country = country;
            Language = language;
            ReleaseDate = releaseDate;
            Storyline = storyline;
            FilmingLocation = filmingLocation;
            Information = information;
        }

        public Movie()
        {

        }
    }
}