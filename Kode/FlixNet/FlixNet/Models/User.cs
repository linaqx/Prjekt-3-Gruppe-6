using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixNet.Models
{
    public class User : Person
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string UserRank { get; set; }
        public List<User> Friends { get; set; }
        public List<FavoriteList> Favoritelists { get; set; }



        public User()
        {
            Friends = new List<User>();
            Favoritelists = new List<FavoriteList>();
        }


    }
}