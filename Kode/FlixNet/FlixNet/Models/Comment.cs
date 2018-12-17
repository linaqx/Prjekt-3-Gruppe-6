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
    public class Comment
    {
        public int Id { get; set; }
        public int Entertainment_Id { get; set; }
        public User User { get; set; }
        public string Message { get; set; }

        /// <summary>
        /// Constructor for Comment
        /// </summary>
        public Comment()
        {
            User = new User();
        }
    }
}