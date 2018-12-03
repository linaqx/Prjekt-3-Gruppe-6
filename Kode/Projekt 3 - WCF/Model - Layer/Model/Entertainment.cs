using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class Entertainment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
        [DataMember]
        public string StoryLine { get; set; }
        [DataMember]
        public string FilmingLocation { get; set; }
        [DataMember]
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