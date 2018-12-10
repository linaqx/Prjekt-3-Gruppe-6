using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class User : Person
    {
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserRank { get; set; }
        [DataMember]
        public List<User> Friends { get; set; }
        [DataMember]
        public List<FavoriteList> Favoritelists { get; set; }

        public User() : base()
        {
            //this.email = email;
            //this.password = password;
            //this.userName = userName;
            //this.userRank = userRank;
            Friends = new List<User>();
            Favoritelists = new List<FavoriteList>();
        }

        //public List<FavoriteList> propFavoriteLists
        //{
        //    get { return Favoritelists; }
        //    set { Favoritelists = value; }
        //}

        public void AddToFavoriteList(FavoriteList favoritelist)
        {
            Favoritelists.Add(favoritelist);
        }

    }
}