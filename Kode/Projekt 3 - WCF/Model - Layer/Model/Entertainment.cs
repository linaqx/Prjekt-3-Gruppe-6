using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Model___Layer.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class Entertainment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Genre Genre { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public Country Country { get; set; }
        [DataMember]
        public Language Language { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
        [DataMember]
        public string StoryLine { get; set; }
        [DataMember]
        public string FilmingLocation { get; set; }
        [DataMember]
        public string Information { get; set; }
        [DataMember]
        public bool IsMovie { get; set; }
        [DataMember]
        public List<Comment> Comments { get; set; }
        
        /// <summary>
        /// Constructor for Entertainment
        /// </summary>
        public Entertainment()
        {
            Comments = new List<Comment>();

        }



        

        



    }
}