using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___library.DB
{
    interface IFavoriteListDB
    {
        List<FavoriteList> FindAllListByUser(int id);
        void AddEntertainmentToFavoriteList(int ent, int fav);
        void CreateNewFavoriteList(int id, string name, string description);
        void AddUserToFavoriteList(int per, int fav);
        void RemoveUserFromFavoriteList(int per, int fav);
    }
}
