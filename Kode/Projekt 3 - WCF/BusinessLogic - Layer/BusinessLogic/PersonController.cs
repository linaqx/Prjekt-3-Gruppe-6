using System;
using System.Collections.Generic;
using System.Linq;
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

       

        public List<FavoriteList> getFavoriteLists(User user)
        {
            return user.propFavoriteLists;
        }

    }
}