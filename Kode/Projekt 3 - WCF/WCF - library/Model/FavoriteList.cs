using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_3___WCF.Model
{
    public class FavoriteList
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Entertainment> Entertianments { get; set; }

        // ret user til int der er ID måske?
        public FavoriteList(User author, string name, string description)
        {
            this.Author = author;
            this.Name = name;
            this.Description = description;
            Entertianments = new List<Entertainment>();
        }

        public FavoriteList()
        {

        }
        
        public void AddEntertainment(Entertainment e)
        {
            Entertianments.Add(e);
        }
    }
}