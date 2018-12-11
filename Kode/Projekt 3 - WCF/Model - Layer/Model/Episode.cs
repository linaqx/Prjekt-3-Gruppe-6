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

        public Episode()
        {
            
        }
    }
}