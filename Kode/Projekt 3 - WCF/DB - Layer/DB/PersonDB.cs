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
    public class PersonDB : IPersonDB
    {
        private readonly string sql_LOGIN_CONFIRMATION = "select [User].person_id as id, [User].userName, [User].[password], [User].email, Person.firstName, Person.lastName, Person.information from [User], Person where [User].person_id = Person.id and [User].userName = @userName;";


        private SqlCommand loginConfirmation;


        private SqlConnection con;


        public PersonDB()
        {
            con = DBConnection.GetInstance().GetConnection();

            loginConfirmation = con.CreateCommand();
        }

        public User LoginConfirmation(string userName)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@userName",
                Value = userName
            };

            loginConfirmation.Parameters.Add(parameter);
            loginConfirmation.CommandText = sql_LOGIN_CONFIRMATION;

            User temp = new User();
            SqlDataReader reader = loginConfirmation.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    UserName = reader.GetString(reader.GetOrdinal("userName")),
                    Password = reader.GetString(reader.GetOrdinal("password"))
                };
                temp = user;
            }

            reader.Close();

            return temp;
        }
    }
}
