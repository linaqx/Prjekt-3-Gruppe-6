﻿using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF___library.DB
{
    class FavoritListDB
    {
        private SqlCommand findAllFavoritList;
        private SqlConnection con;

        public FavoritListDB()
        {
            con = DBConnection.GetInstance().GetConnection();
            findAllFavoritList = con.CreateCommand();
        }

        public List<FavoriteList> FindAllListByUser(User user)
        {
            List<FavoriteList> temp = new List<FavoriteList>();
            findAllFavoritList.CommandText = "";
            return null;
        }
    }
}