﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_3___WCF.Model
{
    public class User : Person
    {
        
        private string email;
        private string password;
        private string userName;
        private string userRank;
        private List<User> friends;
        private List<FavoriteList> favoritelists;

        

        
        public User(string firstName, string lastName, string information, string email, string password, string userName, string userRank) : base(firstName, lastName, information)
        {
            
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.userRank = userRank;
            friends = new List<User>();
            favoritelists = new List<FavoriteList>();
        }




        public List<FavoriteList> propFavoriteLists
        {
            get { return favoritelists; }
            //set { favoritelists = value; }
        }

        public void AddToFavoriteList(FavoriteList favoritelist)
        {
            favoritelists.Add(favoritelist);
        }

    }
}