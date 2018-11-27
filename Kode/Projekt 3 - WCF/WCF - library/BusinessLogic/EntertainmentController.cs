using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF___library.DB;

namespace Projekt_3___WCF.BusinessLogic
{
    public class EntertainmentController
    {
        private EntertainmentDB edb;

        public EntertainmentController()
        {
            edb = new EntertainmentDB();
        }


        //Tilføj en entertainment til en users egen favorit liste
        public void addEntertainmentToFavorit()
        {

        }


        public Entertainment FindEntertainmentByName(List<Entertainment> e)
        {


            return null;
        }

        public List<Entertainment> FindAllEntertainments()
        {

            return edb.GetAllEntertainments();
        }


    }
}