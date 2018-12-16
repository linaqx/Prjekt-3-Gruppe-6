using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_3___WCF.Model;
using Projekt_3___WCF.BusinessLogic;
using System.Collections.Generic;
using WCF___library;
using WCF___Session;
using DB___Layer.DB;
using Model___Layer.Model;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        static void Main(string[] args)
        {
            

        }

        [TestMethod]
        public void FindAllEntertainments()
        {
            Console.WriteLine("TestAddToMyList initiated");
            Console.WriteLine("---------------------------");

            //Arrange
            EntertainmentService es = new EntertainmentService();
            List<Entertainment> entertainments = new List<Entertainment>();

            //Act
            entertainments = es.FindAllEntertainments();

            //Assert
            Assert.AreEqual(4, entertainments.Count);

            Console.WriteLine("TestAddToMyList complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }


        [TestMethod]
        public void FindMovieById()
        {
            Console.WriteLine("TestAddToMyList initiated");
            Console.WriteLine("---------------------------");

            //Arrange
            EntertainmentService es = new EntertainmentService();
            int movie_ID = 1;

            //Act
            Movie movie = es.GetMovieById(movie_ID);

            //Assert
            Assert.AreEqual("Iron Man", movie.Title);

            Console.WriteLine("TestAddToMyList complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }

        [TestMethod]
        public void LoginConfirmation()
        {
            Console.WriteLine("TestAddToMyList initiated");
            Console.WriteLine("---------------------------");

            //Arrange
            Service1 ss = new Service1();
            User user = new User
            {
                Password = "password",
                UserName = "Linaqx"
            };
            User u = new User();

            //Act
            u = ss.LoginConfirmation(user);

            //Assert
            Assert.AreEqual(1, u.Id);

            Console.WriteLine("TestAddToMyList complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }

        [TestMethod]
        public void InsertComment()
        {
            Console.WriteLine("TestAddToMyList initiated");
            Console.WriteLine("---------------------------");

            //Arrange
            SessionDB sDB = new SessionDB();
            int person_id = 1;
            int user_id = 1;
            int entertainment_id = 1;
            string message = "Awww YEAH!";

            //Act
            Session sessiondb = sDB.FindSession(person_id);
            EntertainmentService es = new EntertainmentService();
            Session session = new Session
            {
                Id = sessiondb.Id,
                Session_id = sessiondb.Session_id
            };

            User user = new User
            {
                Id = user_id,
                Session = session
            };

            Comment comment = new Comment
            {
                Entertainment_Id = entertainment_id,
                Message = message,
                User = user
            };

            es.InsertComment(comment);
            Movie movie = es.GetMovieById(entertainment_id);
            List<Comment> comments = movie.Comments;

            //Assert
            Assert.AreEqual(3, comments.Count);

            Console.WriteLine("TestAddToMyList complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }





    }
}
