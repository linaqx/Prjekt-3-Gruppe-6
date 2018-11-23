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
        //Entertainment ent = new Entertainment();
        public List<Entertainment> GetEntertainments()
        {
            Service1.

            Service1.Service1Client sC = new Service1.Service1Client();
            Array.ConvertAll(sC.FindAllEntertainments, );
            List<Entertainment> temp = new List<Entertainment>();
            temp = sC.FindAllEntertainments();

            return sC.FindAllEntertainments();
            
        }


    }
}