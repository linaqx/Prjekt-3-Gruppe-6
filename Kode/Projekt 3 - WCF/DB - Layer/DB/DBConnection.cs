using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projekt_3___WCF.DB
{
    public class DBConnection
    {
        //static void Main(string[] args)
        //{

        //    //readonly string dbName = "dmab0917_1026423";
        //    //static readonly string serverAddress = "kraka.ucn.dk"; //Kraka address - DROP IKKE DATABASE
        //    //static readonly int serverPort = 1433;
        //    //static readonly string userName = "dmab0917_1026423";
        //    //static readonly string password = "Password1!";

        //    //SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=dmab0917_1026423;Integrated security=true");
        //    //SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6;Integrated security=true");
        //    //Data Source = 127.2.3.4\SQLEXPRESS,1433; Network Library = DBMSSOCN; Initial Catalog = dbase; User ID = sa; Password = password
        //    //String connectionString = String.format("jdbc:sqlserver://%s:%d;databaseName=%s;user=%s;password=%s",
        //    //    serverAddress, serverPort, dbName, userName, password);

        //    SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();

        //    sqlConnectionString.DataSource = "kraka.ucn.dk";
        //    sqlConnectionString.InitialCatalog = "dmab0917_1026423";
        //    sqlConnectionString.IntegratedSecurity = false;
        //    sqlConnectionString.UserID = "dmab0917_1026423";
        //    sqlConnectionString.Password = "Password1!";
        //    //190.xxx.xxx.xxx\ServerName
        //    //b.InitialCatalog = "DataBaseName";
        //    //b.IntegratedSecurity = false;
        //    //b.UserId = "...";
        //    //b.Password = "...";

        //    //string connectionString = b.ConnectionString;
        //    string connectionString = sqlConnectionString.ConnectionString;
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    connection.Open();

        //    //SqlCommand cmd = new SqlCommand("select name from [Projekt3_Gruppe6].[dbo].[Country]", connection);
        //    //SqlCommand cmd = new SqlCommand("select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;", connection);
        //    //SqlCommand cmd = new SqlCommand("select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.storyline, Entertainment.information, Country.[name] as country, [Language].[name] as [language] from Entertainment INNER JOIN Country on(Entertainment.country_id = Country.id) INNER JOIN[Language] on(Entertainment.language_id = [Language].id); ", connection);
        //    SqlCommand cmd = new SqlCommand("select Entertainment.id, Entertainment.title, Entertainment.releaseDate from Entertainment;", connection);

        //    SqlDataReader reader = cmd.ExecuteReader();


        //    while (reader.Read())
        //    {
        //        //Console.WriteLine("{0}", reader.GetString(0));
        //        //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7));
        //        //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
        //        Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2));
        //    }
        //    reader.Close();
        //    connection.Close();

        //    if (Debugger.IsAttached)
        //    {
        //        Console.ReadLine();
        //    }
        //}

        private SqlConnection connection = null;
        private static DBConnection dBConnection;
        
        //Kraka connection/database information
        private static readonly string dbName = "dmab0917_1026423";
        private static readonly string serverAddress = "kraka.ucn.dk"; //Kraka address - DROP IKKE DATABASE
        //private static readonly int serverPort = 1433;
        private static readonly Boolean integratedSecurity = false;
        private static readonly string userName = "dmab0917_1026423";
        private static readonly string password = "Password1!";

        private DBConnection()
        {
            try
            {
                OpenSQLConnection();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static DBConnection GetInstance()
        {
            if (dBConnection == null)
            {
                dBConnection = new DBConnection();
            }
            return dBConnection;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }


        private void OpenSQLConnection()
        {
            string connectionString = GetConnectionString();
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                dBConnection = null;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private string GetConnectionString()
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();

            sqlConnectionString.DataSource = serverAddress;
            sqlConnectionString.InitialCatalog = dbName;
            sqlConnectionString.IntegratedSecurity = integratedSecurity;
            sqlConnectionString.UserID = userName;
            sqlConnectionString.Password = password;

            string connectionString = sqlConnectionString.ConnectionString;

            return connectionString;
        }


        public void StartTransaction(string commandText)
        {
            for (int i = 1; i < 10; i++)
            {
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTransaction;

                try
                {
                    command.CommandText = commandText;
                    command.ExecuteNonQuery();
                    //command fix!!!!!! - validate
                    sqlTransaction.Commit();
                }
                catch (Exception)
                {
                    try
                    {
                        sqlTransaction.Rollback();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    throw;
                }

                if(i == 10)
                {
                    new Exception("Something went wrong, please try again.");
                }
            }

        }
    }
}
