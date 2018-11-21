using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_3___WCF.Model;
using Projekt_3___WCF.BusinessLogic;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        static void Main(string[] args)
        {

            
        }

        private User user;
        private List<Entertainment> templist;


        //fix datetime så den ikke er dateTime.now
        [TestMethod]
        public void TestAddToMyList()
        {
            Console.WriteLine("TestAddToMyList initiated");
            Console.WriteLine("---------------------------");
            //AAA
            // arrange, act, assert
            PersonController pC = new PersonController();
            //User
            User monsterMike = new User("mike", "hansen", "et-øjet ork", "mike@elskerBanan.com", "HenningsMor", "MonsterMike", "1");
            //List
            FavoriteList f = new FavoriteList(monsterMike, "Horror", "dette er horror");
            monsterMike.AddToFavoriteList(f);
            //pC.CreateFavoriteList(monsterMike, "Horror", "Her er mine yndlingds horror film");
            //Movie
            Movie m = new Movie("Horror", "scary movie 1", "USA", "English", DateTime.Now, "Funny horror movie", "New York", "blabla");
            // add movie to Horror
            //f.AddEntertainment(m);

            //Act

            int firstCount = f.PropEntertianments.Count;

            f.AddEntertainment(m);

            int lastCount = f.PropEntertianments.Count;

            //Assert
            Assert.AreEqual(firstCount + 1, lastCount);

            Console.WriteLine("TestAddToMyList complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }


        [TestMethod]
        public void FindEntertainmentByName()
        {
            //Arrange

            //Entertainment entertainment1 = new Entertainment("bla", "bla", "bla", "bla", DateTime.Today, "bla", "bla", "bla");
            Entertainment entertainment1 = new Entertainment();
            Movie movie1 = new Movie("Horror", "Van Helsing", "USA", "English", DateTime.Today, "vampyr slayer", "california", "A movie about vampire killign");
            Series series1 = new Series("Comedy", "HIMYM", "USA", "English", DateTime.Today, "How i met your mother", "New York", "A series about barney");
            Episode episode1 = new Episode(1, 1, "Pilot", DateTime.Today, "Started here", series1);
            Movie movie2 = new Movie("Comedy", "Tenacious d", "America", "English", DateTime.Today, "Epic tale of two musicians", "In Hell", "Best goddamm music ever made");
            //lav en liste af entertainments
            templist = new List<Entertainment>();

            templist.Add(entertainment1);
            templist.Add(movie1);
            templist.Add(series1);
            templist.Add(movie2);

            Boolean hasEntertainmentBeenFound = false;

            

           

            //Act
            

            //lav en FindEntertainmentByName metode
            //set

            //Assert


            Assert.IsTrue(hasEntertainmentBeenFound);

            Console.WriteLine("FindEntertainmentByName complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }

        [TestMethod]
        public void FindEntertainmentByGenre()
        {



            Console.WriteLine("FindEntertainmentByGenre complete");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }






    }
}
