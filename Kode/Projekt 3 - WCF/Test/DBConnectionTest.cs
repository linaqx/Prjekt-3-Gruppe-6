using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCF___library.DB;
using Projekt_3___WCF.Model;

namespace Test
{
    [TestClass]
    public class DBConnectionTest
    {
        

        [TestMethod]
        public void TestDBEntertainment()
        {
            //Assemble


            //Act
            //DBConnection dbc = new DBConnection
            EntertainmentDB eDB = new EntertainmentDB();
            eDB.GetEntertainments();
            //Assert
            Assert.AreEqual(1, 1);

        }
    }
}
