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
    public class Rating
    {
        public int Id { get; set; }
        public int Rating_Value { get; set; }

        /// <summary>
        /// Constructor for Rating
        /// </summary>
        public Rating()
        {

        }
    }
}