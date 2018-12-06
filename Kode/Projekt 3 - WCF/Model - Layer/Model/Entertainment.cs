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
        public string StoryLine { get; set; }
        [DataMember]
        public int FilmingLocation { get; set; }
        [DataMember]
        public string Information { get; set; }
        [DataMember]
        public bool IsMovie { get; set; }
        
        public Entertainment(int genre, string title, int country, int language, DateTime realeaseDate, string storyLine, int filmingLocation, string information)
        {
            Genre = genre;
            Title = title;
            Country = country;
            Language = language;
            ReleaseDate = realeaseDate;
            StoryLine = storyLine;
            FilmingLocation = filmingLocation;
            Information = information;

        }

        public Entertainment()
        {

        }



        

        



    }
}