using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class FavoriteList
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Author { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<Entertainment> Entertainments { get; set; }

        /// <summary>
        /// Constructor for favoritelist
        /// </summary>
        public FavoriteList()
        {

        }
        
        public void AddEntertainment(Entertainment e)
        {
            Entertainments.Add(e);
        }
    }
}