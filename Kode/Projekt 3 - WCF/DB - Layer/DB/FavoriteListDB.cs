﻿using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WCF___library.DB
{
    public class FavoriteListDB : FavoriteListDBIF
    {
        //fix number 1 with random number
        private readonly string sql_FIND_ALL_LISTS_BY_USER = "select FavoriteList.id, FavoriteList.[name], FavoriteList.[description] from PersonFavoriteList, FavoriteList where PersonFavoriteList.person_id = @id and PersonFavoriteList.favoriteList_id = FavoriteList.id;";

        private readonly string sql_ADD_ENTERTAINMENT_TO_FAVORITELIST = "insert into EntertainmentFavoriteList (entertainment_id, favoriteList_id) values (@entertainment_id, @favoriteList_id);";
        private readonly string sql_ADD_USER_TO_FAVORITELIST = "insert into PersonFavoriteList (person_id, favoriteList_id) values (@person_id, @favoriteList_id);";

        private readonly string sql_CREATE_NEW_FAVORITELIST = "insert into FavoriteList (author, [name], [description]) values (@author, @name, @description);";

        private SqlCommand findAllFavoritList;
        private SqlCommand addEntertainmentToFavoriteList;
        private SqlCommand addUserToFavoriteList;
        private SqlCommand createNewfavoriteList;
        private SqlConnection con;

        public FavoriteListDB()
        {
            con = DBConnection.GetInstance().GetConnection();
            findAllFavoritList = con.CreateCommand();
            addEntertainmentToFavoriteList = con.CreateCommand();
            addUserToFavoriteList = con.CreateCommand();
            createNewfavoriteList = con.CreateCommand();
        }

        public List<FavoriteList> FindAllListByUser(int id)
        {
            try
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };

                findAllFavoritList.Parameters.Add(parameter);
                findAllFavoritList.CommandText = sql_FIND_ALL_LISTS_BY_USER;

                List<FavoriteList> temp = new List<FavoriteList>();

                SqlDataReader reader = findAllFavoritList.ExecuteReader();
                while (reader.Read())
                {
                    FavoriteList f = new FavoriteList
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Description = reader.GetString(reader.GetOrdinal("description")),
                    };

                    temp.Add(f);

                }
                return temp;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void AddEntertainmentToFavoriteList(int ent, int fav)
        {
            TransactionOptions to = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, to))
            {
                addEntertainmentToFavoriteList.CommandText = sql_ADD_ENTERTAINMENT_TO_FAVORITELIST;
                addEntertainmentToFavoriteList.Parameters.AddWithValue("@entertainment_id", ent);
                addEntertainmentToFavoriteList.Parameters.AddWithValue("@FavoriteList_id", fav);
                addEntertainmentToFavoriteList.ExecuteNonQuery();
                scope.Complete();
            }

        }

        public void CreateNewFavoriteList(int id, string name, string description)
        {
            TransactionOptions to = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, to))
            {
                createNewfavoriteList.CommandText = sql_CREATE_NEW_FAVORITELIST;
                createNewfavoriteList.Parameters.AddWithValue("@author", id);
                createNewfavoriteList.Parameters.AddWithValue("@name", name);
                createNewfavoriteList.Parameters.AddWithValue("@description", description);
                scope.Complete();
            }
        }

        public void AddUserToFavoriteList(int per, int fav)
        {
            TransactionOptions to = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, to))
            {
                //(person_id, favoriteList_id)
                addUserToFavoriteList.CommandText = sql_ADD_USER_TO_FAVORITELIST;
                addUserToFavoriteList.Parameters.AddWithValue("person_id", per);
                addUserToFavoriteList.Parameters.AddWithValue("favoriteList_id", fav);
                scope.Complete();
            }
        }
    }


}

