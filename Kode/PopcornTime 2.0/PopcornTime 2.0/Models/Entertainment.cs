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

        public Entertainment(int id, Genre genre, string title, Country country, Language language, DateTime releaseDate, string storyLine, string filmingLocation, string information)
            {
                this.Id = id;
                this.Genre = genre;
                this.Title = title;
                this.Country = country;
                this.Language = language;
                this.ReleaseDate = releaseDate;
                this.StoryLine = storyLine;
                this.FilmingLocation = filmingLocation;
                this.Information = information;

            }

        public Entertainment()
        {

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