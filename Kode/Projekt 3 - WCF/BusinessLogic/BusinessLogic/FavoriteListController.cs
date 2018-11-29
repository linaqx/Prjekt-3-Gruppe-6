using System;
using System.Collections.Generic;
using System.Linq;
using Projekt_3___WCF.Model;
using WCF___library.DB;

namespace Projekt_3___WCF.BusinessLogic
{
    public class FavoriteListController
    {
        private FavoriteListDB FDB;

        public FavoriteListController()
        {
            FDB = new FavoriteListDB();
        }
        
        public FavoriteList CreateFavoriteList(User author, string name, string description)
        {
            FavoriteList fL = new FavoriteList(author, name, description);
            return fL;
        }

        public List<FavoriteList> FindAllListByUser(int id)
        {
            return FDB.FindAllListByUser(id);
        }

        //public List<Entertainment> FindFavoriteListByName(List<FavoriteList> listOfList, string nameOfList)
        //{
        //    List<Entertainment> temp = new List<Entertainment>();
        //    temp = listOfList.Find(x => x.PropEntertianments.Contains(nameOfList));
        //    return temp;
        //}

    }
}