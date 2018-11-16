using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DBConnection
    {
        static void Main(string[] args)
        {

            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6;Integrated security=true");
            connection.Open();

            //SqlCommand cmd = new SqlCommand("select name from [Projekt3_Gruppe6].[dbo].[Country]", connection);
            //SqlCommand cmd = new SqlCommand("select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;", connection);
            SqlCommand cmd = new SqlCommand("select * from Entertainment;", connection);

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                //Console.WriteLine("{0}", reader.GetString(0));
                //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7));
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6));
            }
            reader.Close();
            connection.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }

        private SqlConnection connection = null;
        private static DBConnection dbConnection;

        private static readonly string driverClass = "com.microsoft.sqlserver.jdbc.SQLServerDriver";

        //Kraka connection/database information
        private static readonly string dbName = "dmab0917_1026423";
        private static readonly string serverAddress = "kraka.ucn.dk"; //Kraka address - DROP IKKE DATABASE
	    private static readonly int serverPort = 1433;
        private static readonly string userName = "dmab0917_1026423";
	    private static readonly string password = "Password1!";

        private string sqlFindEntertainment = "select * from Entertainment;";
        private string sqlFindMovieEntertainment = "select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;";
        private string sqlFindSeriesEntertainment = "select * from Entertainment, Series where Series.entertainment_id = Entertainment.id;";

        public DBConnection()
        {

        }

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6;Integrated security=true");
            connection.Open();
            return connection;
        }

        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
