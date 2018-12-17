using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class Episode
    {
        [DataMember]
        private int Number { get; set; }
        [DataMember]
        private int Season { get; set; }
        [DataMember]
        private string Title { get; set; }
        [DataMember]
        private DateTime ReleaseDate { get; set; }
        [DataMember]
        private string StoryLine { get; set; }
        [DataMember]
        private Series Series { get; set; }

        /// <summary>
        /// Constructor for episode
        /// </summary>
        public Episode()
        {
            
        }
    }
}