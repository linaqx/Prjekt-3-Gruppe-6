using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekt_3___WCF.Model;

namespace Projekt_3___WCF.BusinessLogic
{
    public class FavoriteListController
    {
        
        public FavoriteList CreateFavoriteList(User author, string name, string description)
        {
            FavoriteList fL = new FavoriteList(author, name, description);
            return fL;
        }


        //public List<Entertainment> FindFavoriteListByName(List<FavoriteList> listOfList, string nameOfList)
        //{
        //    List<Entertainment> temp = new List<Entertainment>();
        //    temp = listOfList.Find(x => x.PropEntertianments.Contains(nameOfList));
        //    return temp;
        //}

    }
}