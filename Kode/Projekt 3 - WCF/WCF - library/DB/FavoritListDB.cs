using Projekt_3___WCF.DB;
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
        //fix number 1 with random number
        private readonly string sql_FIND_ALL_LISTS_BY_USER = "select FavoriteList.[name], FavoriteList.[description] from PersonFavoriteList, FavoriteList where PersonFavoriteList.person_id = @id and PersonFavoriteList.favoriteList_id = FavoriteList.id;";

        

        private SqlCommand findAllFavoritList;
        private SqlConnection con;

        public FavoritListDB()
        {
            con = DBConnection.GetInstance().GetConnection();
            findAllFavoritList = con.CreateCommand();
        }

        public List<FavoriteList> FindAllListByUser(int id)
        {
            try
            {
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@id";
                parameter.Value = id;

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
                        Description = reader.GetString(reader.GetOrdinal("releaseDate")),
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





    }
}
