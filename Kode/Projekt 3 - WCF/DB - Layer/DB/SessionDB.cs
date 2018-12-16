using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model___Layer.Model;
using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;

namespace DB___Layer.DB
{
    public class SessionDB : ISessionDB
    {
        private readonly string sql_LOGIN_CONFIRMATION = "select [User].person_id as id, [User].userName, [User].[password], [User].email, Person.firstName, Person.lastName, Person.information from [User], Person where [User].person_id = Person.id and [User].userName = @userName;";
        private readonly string sql_LOGOUT = "delete from [Session] where person_id = @person_id;";

        private readonly string sql_FIND_SESSION = "select [Session].id, [Session].session_id from [Session] where [Session].person_id = @person_id;";

        private readonly string sql_INSERT_SESSION = "insert into [Session] (person_id, session_id) output inserted.id values (@person_id, @session_id);";

        
        private SqlCommand loginConfirmation;
        private SqlCommand logout;

        private SqlCommand findSession;

        private SqlCommand insertSession;

        private SqlConnection con;

        public SessionDB()
        {
            con = DBConnection.GetInstance().GetConnection();

            loginConfirmation = con.CreateCommand();
            logout = con.CreateCommand();

            findSession = con.CreateCommand();

            insertSession = con.CreateCommand();
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

        public Session FindSession(int person_id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "person_id",
                Value = person_id
            };

            findSession.Parameters.Add(parameter);
            findSession.CommandText = sql_FIND_SESSION;

            Session temp = new Session();
            SqlDataReader reader = findSession.ExecuteReader();

            while (reader.Read())
            {
                Session session = new Session
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Session_id = reader.GetString(reader.GetOrdinal("session_id"))
                };
                temp = session;
            }
            reader.Close();

            return temp;
        }

        public int InsertSession(int id, string session_id)
        {
            int insertedId = -1;
            insertSession.CommandText = sql_INSERT_SESSION;
            insertSession.Parameters.AddWithValue("@person_id", id);
            insertSession.Parameters.AddWithValue("@session_id", session_id);
            insertedId = (int)insertSession.ExecuteScalar();
            return insertedId;
        }

        public void LogOut(int person_id)
        {
            logout.CommandText = sql_LOGOUT;
            logout.Parameters.AddWithValue("@person_id", person_id);
            logout.ExecuteNonQuery();
        }

    }
}
