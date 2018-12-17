using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projekt_3___WCF.Model;
using Projekt_3___WCF.BusinessLogic;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace FavoriteListService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private FavoriteListController FLC;

        /// <summary>
        /// Constructor for Service1
        /// </summary>
        public Service1()
        {
            FLC = new FavoriteListController();
        }

        /// <summary>
        /// Finds all favoritelist by user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List<id></returns>
        public List<FavoriteList> FindAllListByUser(int id)
        {
            return FLC.FindAllListByUser(id);
        }

        /// <summary>
        /// adds entertainment to a favoritelist
        /// </summary>
        /// <param name="ent"></param>
        /// <param name="fav"></param>
        public void AddEntertainmentToFavoriteList(int ent, int fav)
        {
            FLC.AddEntertainmentToFavoriteList(ent, fav);
        }

        /// <summary>
        /// Create new favoritelist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public void CreateNewFavoriteList(int id, string name, string description)
        {
            FLC.CreateNewFavoriteList(id, name, description);
        }

        /// <summary>
        /// Adds a user to favorite list
        /// </summary>
        /// <param name="per"></param>
        /// <param name="fav"></param>
        public void AddUserToFavoriteList(int per, int fav)
        {
            FLC.AddUserToFavoriteList(per, fav);
        }

        /// <summary>
        /// remove user from favoritelist
        /// </summary>
        /// <param name="per"></param>
        /// <param name="fav"></param>
        public void RemoveUserFromFavoriteList(int per, int fav)
        {
            FLC.RemoveUserFromFavoriteList(per, fav);
        }
    }
}
