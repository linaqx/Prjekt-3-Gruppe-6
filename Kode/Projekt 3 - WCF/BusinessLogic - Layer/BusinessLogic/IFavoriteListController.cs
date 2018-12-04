using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;

namespace BusinessLogic___Layer.BusinessLogic
{
    interface IFavoriteListController
    {
        List<FavoriteList> FindAllListByUser(int id);
        void AddEntertainmentToFavoriteList(int ent, int fav);
        void CreateNewFavoriteList(int id, string name, string description);
        void AddUserToFavoriteList(int per, int fav);
    }
}
