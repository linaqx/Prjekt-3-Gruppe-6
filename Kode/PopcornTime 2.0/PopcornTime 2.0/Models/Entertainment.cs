using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornTime_2._0.Models
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



        public Entertainment()
        {
            List<Comment> comments = new List<Comment>();
        }

        //public Entertainment(string title, DateTime releaseDate)
        //{

        //    this.title = title;
        //    this.releaseDate = releaseDate;
        //}



            //brug den her til listen på index viewwed
            //public Entertainment(string title, DateTime realeaseDate)
            //{
            //    this.title = title;
            //    this.releaseDate = releaseDate;
            //}

            //public Entertainment()
            //{

            //}


        }

    
}