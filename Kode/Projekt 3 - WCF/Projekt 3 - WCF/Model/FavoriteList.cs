using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_3___WCF.Model
{
    public class FavoriteList
    {
        private int author;
        private string name;
        private string description;
        private List<Entertainment> entertainments;

        public FavoriteList(int author, string name, string description)
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

    }
}