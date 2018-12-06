using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornTime_2._0.Models
{
    public class FavoriteList
    {

        public int Id { get; set; }
        public int Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Entertainment> Entertainments { get; set; }

        // ret user til int der er ID måske?
        public FavoriteList(int author, string name, string description)
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
