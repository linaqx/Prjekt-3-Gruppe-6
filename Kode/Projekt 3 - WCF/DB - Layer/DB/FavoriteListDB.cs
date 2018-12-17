using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___library.DB
{
    public class FavoriteListDB : IFavoriteListDB
    {
        private readonly string sql_FIND_ALL_LISTS_BY_USER = "select FavoriteList.id, FavoriteList.[name], FavoriteList.[description] from PersonFavoriteList, FavoriteList where PersonFavoriteList.person_id = @id and PersonFavoriteList.favoriteList_id = FavoriteList.id;";

        private readonly string sql_ADD_ENTERTAINMENT_TO_FAVORITELIST = "insert into EntertainmentFavoriteList (entertainment_id, favoriteList_id) values (@entertainment_id, @favoriteList_id);";
        private readonly string sql_ADD_USER_TO_FAVORITELIST = "insert into PersonFavoriteList (person_id, favoriteList_id) values (@person_id, @favoriteList_id);";

        private readonly string sql_CREATE_NEW_FAVORITELIST = "insert into FavoriteList (author, [name], [description]) values (@author, @name, @description);";

        private readonly string sql_REMOVE_USER_FROM_FAVORITELIST = "delete from PersonFavoriteList where person_id = @person_id and favoriteList_id = @favoriteList_id;";

        private SqlCommand findAllFavoritList;
        private SqlCommand addEntertainmentToFavoriteList;
        private SqlCommand addUserToFavoriteList;
        private SqlCommand createNewfavoriteList;
        private SqlCommand removeUserFromFavoriteList;
        private SqlConnection con;

        /// <summary>
        /// Constructor for FavoriteList
        /// </summary>
        public FavoriteListDB()
        {
            con = DBConnection.GetInstance().GetConnection();
            findAllFavoritList = con.CreateCommand();
            addEntertainmentToFavoriteList = con.CreateCommand();
            addUserToFavoriteList = con.CreateCommand();
            createNewfavoriteList = con.CreateCommand();
            removeUserFromFavoriteList = con.CreateCommand();
        }

        /// <summary>
        /// gets all favorite list by user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List<FavoriteList></returns>
        public List<FavoriteList> FindAllListByUser(int id)
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
            reader.Close();
            return temp;
        }

        /// <summary>
        /// Adds a Entertainment to afavorite list
        /// </summary>
        /// <param name="ent"></param>
        /// <param name="fav"></param>
        public void AddEntertainmentToFavoriteList(int ent, int fav)
        {
            addEntertainmentToFavoriteList.CommandText = sql_ADD_ENTERTAINMENT_TO_FAVORITELIST;
            addEntertainmentToFavoriteList.Parameters.AddWithValue("@entertainment_id", ent);
            addEntertainmentToFavoriteList.Parameters.AddWithValue("@FavoriteList_id", fav);
            addEntertainmentToFavoriteList.ExecuteNonQuery();
        }

        /// <summary>
        /// Creates a new favoritelist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public void CreateNewFavoriteList(int id, string name, string description)
        {
            createNewfavoriteList.CommandText = sql_CREATE_NEW_FAVORITELIST;
            createNewfavoriteList.Parameters.AddWithValue("@author", id);
            createNewfavoriteList.Parameters.AddWithValue("@name", name);
            createNewfavoriteList.Parameters.AddWithValue("@description", description);
        }

        /// <summary>
        /// Adds a user to a favoritelist
        /// </summary>
        /// <param name="per"></param>
        /// <param name="fav"></param>
        public void AddUserToFavoriteList(int per, int fav)
        {
            addUserToFavoriteList.CommandText = sql_ADD_USER_TO_FAVORITELIST;
            addUserToFavoriteList.Parameters.AddWithValue("@person_id", per);
            addUserToFavoriteList.Parameters.AddWithValue("@favoriteList_id", fav);
        }

        /// <summary>
        /// Removes a user from a favorite list
        /// </summary>
        /// <param name="per"></param>
        /// <param name="fav"></param>
        public void RemoveUserFromFavoriteList(int per, int fav)
        {
            removeUserFromFavoriteList.CommandText = sql_REMOVE_USER_FROM_FAVORITELIST;
            removeUserFromFavoriteList.Parameters.AddWithValue("@person_id", per);
            removeUserFromFavoriteList.Parameters.AddWithValue("@favoriteList_id", fav);

        }
    }
}

