using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{

    [DataContract]
    public class Person
    {
        [DataMember]
        private string FirstName { get; set; }
        [DataMember]
        private string LastName { get; set; }
        [DataMember]
        private string Information { get; set; }
        
        //public Person(string firstName, string lastName, string information)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Information = information;
        //}

        public Person()
        {

        }
    }
}