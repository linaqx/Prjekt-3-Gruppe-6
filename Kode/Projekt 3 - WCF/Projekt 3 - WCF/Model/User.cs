using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_3___WCF.Model
{
    public class User : Person
    {
        private int author;
        private string email;
        private string password;
        private string userName;
        private string userRank;
        private List<User> friends;
        private List<FavoriteList> favoritelists;

        

        //HUSK at slette author
        public User(int author, string firstName, string lastName, string information, string email, string password, string userName, string userRank) : base(firstName, lastName, information)
        {
            this.author = author;
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.userRank = userRank;
            friends = new List<User>();
            favoritelists = new List<FavoriteList>();
        }



        

        public int PropAuthor
        {
            get { return author; }
            set { author = value; }
        }



        public List<FavoriteList> propFavoriteLists
        {
            get { return favoritelists; }
            set { favoritelists = value; }
        }

    }
}