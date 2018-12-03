using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model___Layer.Model
{
    public class Language
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Language(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Language()
        {

        }
    }
}
