using DB___Layer.DB;
using Model___Layer.Model;
using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF___EntertainmentAdmin;
using WCF___library;
using WCF___library.DB;
using WCF___Session;

namespace midlertidigTest
{
    class Test
    {
        static void Main(string[] args)
        {
            EntertainmentDB edb = new EntertainmentDB();
            EntertainmentService es = new EntertainmentService();
            EntertainmentAdminService eas = new EntertainmentAdminService();
            Service1 ss = new Service1();
            SessionDB sDB = new SessionDB();

            //List<Entertainment> temp = edb.GetAllEntertainments();
            //foreach (Entertainment ent in temp)
            //{
            //    Console.WriteLine(ent.Id);
            //    Console.WriteLine(ent.Title);
            //    Console.WriteLine(ent.ReleaseDate);
            //}

            //edb.GetPersonalEntertainments(1);

            List<Entertainment> temp2 = es.FindAllEntertainments();
            foreach (Entertainment ent2 in temp2)
            {
                Console.WriteLine(ent2.Id);
                Console.WriteLine(ent2.Title);
                Console.WriteLine(ent2.ReleaseDate);
            }

            //List<Genre> genres = edb.GetAllGenres();
            //foreach (Genre genre in genres)
            //{
            //    Console.WriteLine(genre.Id);
            //    Console.WriteLine(genre.Name);
            //}

            //List<Country> countries = edb.GetAllCountries();
            //foreach (Country country in countries)
            //{
            //    Console.WriteLine(country.Id);
            //    Console.WriteLine(country.Name);
            //}

            //Movie movie = new Movie
            //{
            //    Title = "Iron Man 4",
            //    Genre = edb.FindGenreByName("Action"),
            //    Country = edb.FindCountryByName("USA"),
            //    Language = edb.FindLanguageByName("English"),
            //    ReleaseDate = DateTime.Now,
            //    StoryLine = "Something Explode",
            //    FilmingLocation = "New York",
            //    Information = "nice",
            //    //IsMovie = true
            //};
            //eas.StartInsertMovieTransaction(movie);


            //Movie testmovie = es.GetMovieById(1);
            //Console.WriteLine(testmovie.Title);

            Movie findMovie = es.GetMovieById(1);
            Console.WriteLine(findMovie.Title);
            Console.WriteLine(findMovie.Country.Name);
            Console.WriteLine(findMovie.Language.Name);
            Console.WriteLine(findMovie.Genre.Name);

            //long ticks = DateTime.Now.Ticks;
            //byte[] bytes = BitConverter.GetBytes(ticks);
            //string id = Convert.ToBase64String(bytes).Replace('+', '_').Replace('/', '-').TrimEnd('=');
            //Console.WriteLine(id);

            User user = new User
            {
                Password = "password",
                UserName = "Linaqx"
            };

            User u = ss.LoginConfirmation(user);
            Console.WriteLine(u.Id);
            Console.WriteLine(u.Session.Session_id);





            Session sessiondb = sDB.FindSession(1);
            Session session = new Session
            {
                Id = sessiondb.Id,
                Session_id = sessiondb.Session_id
            };

            User user1 = new User
            {
                Id = 1,
                Session = session
            };

            Comment comment = new Comment
            {
                Entertainment_Id = 1,
                Message = "Awwww YEAH!",
                User = user1
            };

            es.InsertComment(comment);
        }
    }
}
