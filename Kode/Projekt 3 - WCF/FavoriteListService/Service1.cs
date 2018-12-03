﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projekt_3___WCF.Model;
using Projekt_3___WCF.BusinessLogic;

namespace FavoriteListService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private FavoriteListController FLC;

        public Service1()
        {
            FLC = new FavoriteListController();
        }

        public List<FavoriteList> FindAllListByUser(int id)
        {
            return FLC.FindAllListByUser(id);
        }

        
    }
}