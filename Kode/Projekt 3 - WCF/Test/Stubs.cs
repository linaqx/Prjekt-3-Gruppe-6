using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Stubs
    {
        private List<Entertainment> stubEntertainments;
        //private Entertainment et;
        //private Movie m;
        //private Series s;
        //private Episode e;
        //private Movie m1;

        static void Main(string[] args)
        {
            
            
        }

        public Stubs(Entertainment et, Movie m, Series s, Episode e, Movie m1)
        {
            // Entertainment entertainment1 = new Entertainment("bla", "bla", "bla", "bla", DateTime.Today, "bla", "bla", "bla");
            Entertainment entertainment1 = new Entertainment();
            //Movie movie1 = new Movie("Horror", "Van Helsing", "USA", "English", DateTime.Today, "vampyr slayer", "california", "A movie about vampire killign");
            //Series series1 = new Series("Comedy", "HIMYM", "USA", "English", DateTime.Today, "How i met your mother", "New York", "A series about barney");
            //Episode episode1 = new Episode(1, 1, "Pilot", DateTime.Today, "Started here", series1);
            //Movie movie2 = new Movie("Comedy", "Tenacious d", "America", "English", DateTime.Today, "Epic tale of two musicians", "In Hell", "Best goddamm music ever made");
            stubEntertainments = new List<Entertainment>();

            stubEntertainments.Add(entertainment1);
            //stubEntertainments.Add(movie1);
            //stubEntertainments.Add(series1);
            //stubEntertainments.Add(movie2);
        }

        public List<Entertainment> returnList()
        {
            return stubEntertainments;
        }

    }
}
