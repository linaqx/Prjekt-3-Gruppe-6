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
        private string email;
        [DataMember]
        private string password;
        [DataMember]
        private string userName;
        [DataMember]
        private string userRank;
        [DataMember]
        private List<User> friends;
        [DataMember]
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
            set { favoritelists = value; }
        }

        public void AddToFavoriteList(FavoriteList favoritelist)
        {
            favoritelists.Add(favoritelist);
        }

    }
}