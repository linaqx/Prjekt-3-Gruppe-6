using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixNet.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Entertainment_Id { get; set; }
        public int User { get; set; }
        public string Message { get; set; }

        public Comment()
        {

        }



    }
}