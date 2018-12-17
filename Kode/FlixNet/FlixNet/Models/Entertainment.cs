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
    public class Entertainment
    {
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public Country Country { get; set; }
        public Language Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string StoryLine { get; set; }
        public string FilmingLocation { get; set; }
        public string Information { get; set; }
        public List<Comment> Comments { get; set; }
        
        /// <summary>
        /// Constructor for Entertainment
        /// </summary>
        public Entertainment()
        {
            List<Comment> comments = new List<Comment>();
        }
    }
}