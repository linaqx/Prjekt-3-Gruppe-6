using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model___Layer.Model
{
    public class FilmingLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FilmingLocation(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public FilmingLocation()
        {

        }
    }
}
