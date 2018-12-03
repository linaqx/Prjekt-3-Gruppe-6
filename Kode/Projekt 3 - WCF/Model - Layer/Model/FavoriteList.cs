using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class FavoriteList
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public User Author { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<Entertainment> Entertainments { get; set; }

        // ret user til int der er ID måske?
        public FavoriteList(User author, string name, string description)
        {
            this.Author = author;
            this.Name = name;
            this.Description = description;
            Entertainments = new List<Entertainment>();
        }

        public FavoriteList()
        {

        }
        
        public void AddEntertainment(Entertainment e)
        {
            Entertainments.Add(e);
        }
    }
}