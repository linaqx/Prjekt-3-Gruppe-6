using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornTime_2._0.Models
{
    public class Country
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public Country(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }
    }
}