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
    public class Movie : Entertainment
    {
        /// <summary>
        /// Constructor for Movie
        /// </summary>
        public Movie()
        {

        }
    }
}