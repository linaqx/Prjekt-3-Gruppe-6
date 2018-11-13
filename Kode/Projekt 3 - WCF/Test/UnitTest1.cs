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
            User monsterMike = new User(3, "mike", "hansen", "et-øjet ork", "mike@elskerBanan.com", "HenningsMor", "MonsterMike", "1");
            //List
            pC.CreateFavoriteList(monsterMike, "Horror", "Her er mine yndlingds horror film");
            //Movie
            Movie m = new Movie("Horror", "scary movie 1", "USA", "English", DateTime.Now, "Funny horror movie", "New York", "blabla");

            
            //Act
            List<Entertainment> AmountOfMoviesFirst = pC.getFavoriteLists(monsterMike);

            FindFavoriteListByName();

            monsterMike.entertainments.addMovie();

            int AmountOfMoviesLast = List.getCount(); 

            //Assert
            Assertequals(AmountOfMoviesFirst + 1, AmountOfMoviesLast);

            Console.WriteLine("TestAddToMyList complete");
            Console.WriteLine("--------------------------");
        }
    }
}
