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
        
        private User user;


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
    }
}
