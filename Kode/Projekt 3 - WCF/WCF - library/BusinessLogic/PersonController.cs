using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekt_3___WCF.Model;

namespace Projekt_3___WCF.BusinessLogic
{
    public class PersonController
    {
        private FavoriteListController fLC;

        public PersonController()
        {
            fLC = new FavoriteListController();
        }

        public void CreateFavoriteList(User user, string name, string description)
        {

            FavoriteList temp = fLC.CreateFavoriteList(user, name, description);
            user.AddToFavoriteList(temp);
        }

        public List<FavoriteList> getFavoriteLists(User user)
        {
            return user.propFavoriteLists;
        }

    }
}