﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projekt_3___WCF.Model;

namespace FavoriteListService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<FavoriteList> FindAllListByUser(int id);

        [OperationContract]
        void AddEntertainmentToFavoriteList(int ent, int fav);

        
    }


}
