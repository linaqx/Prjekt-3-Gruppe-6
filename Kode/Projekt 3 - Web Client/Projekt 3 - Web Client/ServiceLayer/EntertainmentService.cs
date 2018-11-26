using Projekt_3___Web_Client.Service1Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service1 = Projekt_3___Web_Client.Service1Reference;



namespace Projekt_3___Web_Client.ServiceLayer
{
    public class EntertainmentService
    {
        Entertainment ent = new Entertainment();
        public List<Entertainment> GetEntertainments()
        {
            
            Service1.Service1Client sC = new Service1.Service1Client();
            var entertainments = sC.FindAllEntertainments().ToList<Entertainment>();
           
            return entertainments;

        }


    }
}