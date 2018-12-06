using Model___Layer.Model;
using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF___library;
using WCF___library.DB;

namespace midlertidigTest
{
    class test
    {
        static void Main(string[] args)
        {
            EntertainmentDB edb = new EntertainmentDB();
            EntertainmentService es = new EntertainmentService();

            List<Entertainment> temp = edb.GetAllEntertainments();
            foreach(Entertainment ent in temp)
            {
                Console.WriteLine(ent.Id);
                Console.WriteLine(ent.Title);
                Console.WriteLine(ent.ReleaseDate);
            }
           
            edb.GetPersonalEntertainments(2);

            List<Entertainment> temp2 = es.FindAllEntertainments();
            foreach (Entertainment ent2 in temp2)
            {
                Console.WriteLine(ent2.Id);
                Console.WriteLine(ent2.Title);
                Console.WriteLine(ent2.ReleaseDate);
            }

            List<Genre> genres = edb.GetAllGenres();
            foreach (Genre genre in genres)
            {
                Console.WriteLine(genre.Id);
                Console.WriteLine(genre.Name);
            }

            List<Country> countries = edb.GetAllCountries();
            foreach (Country country in countries)
            {
                Console.WriteLine(country.Id);
                Console.WriteLine(country.Name);
            }

            Movie movie = new Movie
            {
                Title = "Iron Man 3",
                Genre = 1,
                Country = 2,
                Language = 1,
                ReleaseDate = DateTime.Now,
                StoryLine = "Something Explode",
                FilmingLocation = 1,
                Information = "nice"
            };
            es.StartInsertMovieTransaction(movie);

        }
    }
}
