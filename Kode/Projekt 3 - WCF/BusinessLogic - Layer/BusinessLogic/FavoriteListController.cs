using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic___Layer.BusinessLogic;
using Projekt_3___WCF.Model;
using WCF___library.DB;

namespace Projekt_3___WCF.BusinessLogic
{
    public class FavoriteListController : IFavoriteListController
    {
        private FavoriteListDB FDB;

        public FavoriteListController()
        {
            FDB = new FavoriteListDB();
        }
        
        public List<FavoriteList> FindAllListByUser(int id)
        {
            return FDB.FindAllListByUser(id);
        }

        public void AddEntertainmentToFavoriteList(int ent, int fav)
        {
            FDB.AddEntertainmentToFavoriteList(ent, fav);
        }

        public void CreateNewFavoriteList(int id, string name, string description)
        {
            FDB.CreateNewFavoriteList(id, name, description);
        }

        public void AddUserToFavoriteList(int per, int fav)
        {
            FDB.AddUserToFavoriteList(per, fav);
        }

        //public List<Entertainment> FindFavoriteListByName(List<FavoriteList> listOfList, string nameOfList)
        //{
        //    List<Entertainment> temp = new List<Entertainment>();
        //    temp = listOfList.Find(x => x.PropEntertianments.Contains(nameOfList));
        //    return temp;
        //}

    }
}