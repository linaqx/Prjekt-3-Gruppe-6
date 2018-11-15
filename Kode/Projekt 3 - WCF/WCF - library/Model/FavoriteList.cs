using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_3___WCF.Model
{
    public class FavoriteList
    {
        private User author;
        private string name;
        private string description;
        private List<Entertainment> entertainments;
        
        // ret user til int der er ID måske?
        public FavoriteList(User author, string name, string description)
        {
            this.author = author;
            this.name = name;
            this.description = description;
            entertainments = new List<Entertainment>();
        }

     

        public List<Entertainment> PropEntertianments
        {
            get { return entertainments; }
            set { entertainments = value; }
        }

        public void AddEntertainment(Entertainment e)
        {
            entertainments.Add(e);
        }
    }
}