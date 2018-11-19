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

            //readonly string dbName = "dmab0917_1026423";
            //static readonly string serverAddress = "kraka.ucn.dk"; //Kraka address - DROP IKKE DATABASE
            //static readonly int serverPort = 1433;
            //static readonly string userName = "dmab0917_1026423";
            //static readonly string password = "Password1!";

            //SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=dmab0917_1026423;Integrated security=true");
            //SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6;Integrated security=true");
            //Data Source = 127.2.3.4\SQLEXPRESS,1433; Network Library = DBMSSOCN; Initial Catalog = dbase; User ID = sa; Password = password
            //String connectionString = String.format("jdbc:sqlserver://%s:%d;databaseName=%s;user=%s;password=%s",
            //    serverAddress, serverPort, dbName, userName, password);

            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();

            sqlConnectionString.DataSource = "kraka.ucn.dk";
            sqlConnectionString.InitialCatalog = "dmab0917_1026423";
            sqlConnectionString.IntegratedSecurity = false;
            sqlConnectionString.UserID = "dmab0917_1026423";
            sqlConnectionString.Password = "Password1!";
            //190.xxx.xxx.xxx\ServerName
            //b.InitialCatalog = "DataBaseName";
            //b.IntegratedSecurity = false;
            //b.UserId = "...";
            //b.Password = "...";

            //string connectionString = b.ConnectionString;
            string connectionString = sqlConnectionString.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
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
        private static SqlConnection connection;

        //private static readonly string driverClass = "com.microsoft.sqlserver.jdbc.SQLServerDriver";

        //Kraka connection/database information
        private static readonly string dbName = "dmab0917_1026423";
        private static readonly string serverAddress = "kraka.ucn.dk"; //Kraka address - DROP IKKE DATABASE
        //private static readonly int serverPort = 1433;
        private static readonly Boolean integratedSecurity = false;
        private static readonly string userName = "dmab0917_1026423";
        private static readonly string password = "Password1!";

        public DBConnection()
        {
            String connectionString = GetConnectionString();
                
            try
            {
                connection = get
                Class.forName(driverClass);
                connection = DriverManager.getConnection(connectionString);
                System.out.println("Connected");
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public static DBConnection getInstance()
        {
            if (dbConnection == null)
            {
                dbConnection = new DBConnection();
            }
            return dbConnection;
        }

        //public Connection getConnection()
        //{
        //    return connection;
        //}

        public SqlConnection OpenSQLConnection()
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }

            return connection;
        }

        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private static string GetConnectionString()
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


        public void startTransaction(SqlConnection connection, string commandText)
        {
            SqlTransaction sqlTransaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = sqlTransaction;

            try
            {
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception)
                {

                    
                }

                throw;
            }
        }

 //       public void commitTransaction() throws SQLException
 //       {
 //           connection.commit();
	//	connection.setAutoCommit(true);
	//}

 //   public void rollbackTransaction() throws SQLException
 //   {
 //       connection.rollback();
 //       connection.setAutoCommit(true);
 //   }

    //        using (IDbTransaction tran = conn.BeginTransaction()) {
    //    try {
    //        // your code
    //        tran.Commit();
    //    }  catch {
    //        tran.Rollback();
    //        throw;
    //    }
    //}

    //    using (SqlConnection connection1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;User Instance=True"))
    //       {
    //           connection1.Open();

    //           // Start a local transaction.
    //           SqlTransaction sqlTran = connection1.BeginTransaction();

    //           // Enlist a command in the current transaction.
    //           SqlCommand command = connection1.CreateCommand();
    //           command.Transaction = sqlTran;

    //           try
    //           {
    //               // Execute two separate commands.
    //               command.CommandText =
    //                "insert into [doctor](drname,drspecialization,drday) values ('a','b','c')";
    //               command.ExecuteNonQuery();
    //               command.CommandText =
    //                "insert into [doctor](drname,drspecialization,drday) values ('x','y','z')";
    //               command.ExecuteNonQuery();

    //               // Commit the transaction.
    //               sqlTran.Commit();
    //               Label3.Text = "Both records were written to database.";
    //           }
    //           catch (Exception ex)
    //           {
    //               // Handle the exception if the transaction fails to commit.
    //               Label4.Text = ex.Message;


    //               try
    //               {
    //                   // Attempt to roll back the transaction.
    //                   sqlTran.Rollback();
    //               }
    //               catch (Exception exRollback)
    //               {
    //                   // Throws an InvalidOperationException if the connection 
    //                   // is closed or the transaction has already been rolled 
    //                   // back on the server.
    //                   Label5.Text = exRollback.Message;

    //               }
    //           }
    //       }


    //        public void startTransaction()
    //        {
    //            TransactionScope
    //            using (TransactionScope tran = new TransactionScope())
    //            {
    //                CallAMethodThatDoesSomeWork();
    //                CallAMethodThatDoesSomeMoreWork();
    //                tran.Complete();
    //            }
    //            connection.
    //            connection.setAutoCommit(false);
    //	}

    //    public void commitTransaction() throws SQLException
    //    {
    //        connection.commit();
    //        connection.setAutoCommit(true);
    //    }

    //    public void rollbackTransaction() throws SQLException
    //    {
    //        connection.rollback();
    //        connection.setAutoCommit(true);

    //    }

}
}
