using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projekt_3___WCF.Model;
using Projekt_3___WCF.BusinessLogic;

namespace WCF___library
{
    
    public class FavoriteListService : IFavoriteListService
    {

        private FavoriteListController FLC;

        public FavoriteListService()
        {
            FLC = new FavoriteListController();
        }

        public List<FavoriteList> FindAllListByUser(int id)
        {
            return FLC.FindAllListByUser(id);
        }
    }
}
