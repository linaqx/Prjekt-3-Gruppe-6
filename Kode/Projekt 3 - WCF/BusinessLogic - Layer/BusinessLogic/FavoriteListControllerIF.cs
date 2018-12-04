using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;

namespace BusinessLogic___Layer.BusinessLogic
{
    interface FavoriteListControllerIF
    {

        FavoriteList CreateFavoriteList(User author, string name, string description);
        List<FavoriteList> FindAllListByUser(int id);
        void AddEntertainmentToFavoriteList(int ent, int fav);
    }
}
