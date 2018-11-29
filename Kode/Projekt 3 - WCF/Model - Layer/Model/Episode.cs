using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class Episode
    {
        [DataMember]
        private int number;
        private int season;
        private string title;
        private DateTime releaseDate;
        private string storyLine;
        private Series serie;

        public Episode(int number, int season, string title, DateTime releaseDate, string storyLine, Series serie)
        {
            this.number = number;
            this.season = season;
            this.title = title;
            this.releaseDate = releaseDate;
            this.storyLine = storyLine;
            this.serie = serie;
        }
    }
}