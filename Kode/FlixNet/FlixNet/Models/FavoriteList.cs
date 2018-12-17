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
    public class FavoriteList
    {
        public int Id { get; set; }
        public int Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Entertainment> Entertainments { get; set; }

        /// <summary>
        /// Constructor for Favoritelist
        /// </summary>
        public FavoriteList()
        {
            Entertainments = new List<Entertainment>();
        }

        /// <summary>
        /// Adds entertainment to entertainments
        /// </summary>
        /// <param name="e"></param>
        public void AddEntertainment(Entertainment e)
        {
            Entertainments.Add(e);
        }
    }
}