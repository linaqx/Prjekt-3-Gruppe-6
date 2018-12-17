using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
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
        public Session Session { get; set; }

        /// <summary>
        /// Constructor for user
        /// </summary>
        public User()
        {
            Friends = new List<User>();
            Favoritelists = new List<FavoriteList>();
            Session = new Session();
        }
    }
}