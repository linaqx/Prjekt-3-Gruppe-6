using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___WCF.DB
{
    public class DBConnection
    {
        private SqlConnection connection = null;
        private static DBConnection dBConnection;
        
        //Kraka connection/database information
        private static readonly string dbName = "dmab0917_1026423";
        private static readonly string serverAddress = "kraka.ucn.dk";
        //private static readonly int serverPort = 1433;
        private static readonly bool integratedSecurity = false;
        private static readonly string userName = "dmab0917_1026423";
        private static readonly string password = "Password1!";

        //Opens the SQL connection
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

        /// <summary>
        /// Gets an instance og DBConnection
        /// </summary>
        /// <returns>DBConnection</returns>
        public static DBConnection GetInstance()
        {
            if (dBConnection == null)
            {
                dBConnection = new DBConnection();
            }
            return dBConnection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return connection;
        }

        /// <summary>
        /// Opens the SQL connection
        /// </summary>
        private void OpenSQLConnection()
        {
            string connectionString = GetConnectionString();
            connection = new SqlConnection
            {
                ConnectionString = connectionString
            };
            connection.Open();
        }

        /// <summary>
        /// Closes the Connection
        /// </summary>
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

        /// <summary>
        /// Gets the connection string
        /// </summary>
        /// <returns></returns>
        private string GetConnectionString()
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder
            {
                DataSource = serverAddress,
                InitialCatalog = dbName,
                IntegratedSecurity = integratedSecurity,
                UserID = userName,
                Password = password
            };
            string connectionString = sqlConnectionString.ConnectionString;

            return connectionString;
        }
    }
}
