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
        private string firstName;
        [DataMember]
        private string lastName;
        [DataMember]
        private string information;
        

        public Person(string firstName, string lastName, string information)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.information = information;
        }

       


    }
}