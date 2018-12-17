using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Model___Layer.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
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
        [DataMember]
        public Session Session { get; set; }

        /// <summary>
        /// Constructor for User
        /// </summary>
        public User() : base()
        {
            Friends = new List<User>();
            Favoritelists = new List<FavoriteList>();
            Session = new Session();
        }

        /// <summary>
        /// Adds a user to a favoritelist
        /// </summary>
        /// <param name="favoritelist"></param>
        public void AddToFavoriteList(FavoriteList favoritelist)
        {
            Favoritelists.Add(favoritelist);
        }

    }
}