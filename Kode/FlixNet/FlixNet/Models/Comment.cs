﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixNet.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Entertainment_Id { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        //public Rating Rating { get; set; }

        public Comment()
        {
            User = new User();

        }



    }
}