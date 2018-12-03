using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornTime_2._0.Models
{
        public class Person
        {
            
            private string firstName;
            private string lastName;
            private string information;


            public Person(string firstName, string lastName, string information)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.information = information;
            }



        }
    }