using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornTime_2._0.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Language(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }


    }
}