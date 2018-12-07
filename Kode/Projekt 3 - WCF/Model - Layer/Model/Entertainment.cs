﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Model___Layer.Model;

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
        [DataMember]
        public List<Comment> Comments { get; set; }
        

        public Entertainment()
        {
            Comments = new List<Comment>();

        }



        

        



    }
}