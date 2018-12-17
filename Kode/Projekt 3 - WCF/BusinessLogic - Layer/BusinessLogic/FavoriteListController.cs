using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic___Layer.BusinessLogic;
using Projekt_3___WCF.Model;
using WCF___library.DB;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___WCF.BusinessLogic
{
    public class FavoriteListController : IFavoriteListController
    {
        private FavoriteListDB FDB;

        /// <summary>
        /// Constructor for favoritListController
        /// </summary>
        public FavoriteListController()
        {
            FDB = new FavoriteListDB();
        }
       
        /// <summary>
        /// Finds all favoritelist by a user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List<favoriteList></returns>
        public List<FavoriteList> FindAllListByUser(int id)
        {
            return FDB.FindAllListByUser(id);
        }

        /// <summary>
        /// Adds an entertainment to a favorite list
        /// </summary>
        /// <param name="ent"></param>
        /// <param name="fav"></param>
        public void AddEntertainmentToFavoriteList(int ent, int fav)
        {
            FDB.AddEntertainmentToFavoriteList(ent, fav);
        }

        /// <summary>
        /// Creates a new favorite list
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public void CreateNewFavoriteList(int id, string name, string description)
        {
            FDB.CreateNewFavoriteList(id, name, description);
        }

        /// <summary>
        /// Adds a user to a favoritelist
        /// </summary>
        /// <param name="per"></param>
        /// <param name="fav"></param>
        public void AddUserToFavoriteList(int per, int fav)
        {
            FDB.AddUserToFavoriteList(per, fav);
        }

        /// <summary>
        /// Removes a user from a favorite list
        /// </summary>
        /// <param name="per"></param>
        /// <param name="fav"></param>
        public void RemoveUserFromFavoriteList(int per, int fav)
        {
            FDB.RemoveUserFromFavoriteList(per, fav);
        }
    }
}