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
    public class EntertainmentDB
    {
        //static void Main(string[] args)
        //{
        //    EntertainmentDB edb = new EntertainmentDB();
        //    edb.GetEntertainments();
        //    DBConnection dBConnection = DBConnection.GetInstance();
        //    dBConnection.CloseConnection();
        //}

        private readonly string sql_FIND_ALL_ENTERTAINMENT = "select Entertainment.id, Entertainment.title, Entertainment.releaseDate from Entertainment;";
        //private readonly string sql_FIND_MOVIE_ENTERTAINMENT = "select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;";
        //private readonly string sql_FIND_SERIES_ENTERTAINMENT = "select * from Entertainment, Series where Series.entertainment_id = Entertainment.id;";

        private SqlCommand findAllEntertainments;

        private SqlConnection con;

        public EntertainmentDB()
        {
            con = DBConnection.GetInstance().GetConnection();
            findAllEntertainments = con.CreateCommand();
        }

        public List<Entertainment> GetEntertainments()
        {
            List<Entertainment> temp = new List<Entertainment>();
            findAllEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT;
            SqlDataReader reader = findAllEntertainments.ExecuteReader();
            while (reader.Read())
            {
                Entertainment e = new Entertainment
                {
                    title = reader.GetString(reader.GetOrdinal("title")),
                    releaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate")),
                };

                temp.Add(e);

            }
            Console.WriteLine(temp.Count());
            Console.ReadLine();
            reader.Close();
            return temp;
        }

        //public List<Entertainment> GetEntertainments()
        //{
        //    List<Entertainment> temp = new List<Entertainment>();
        //    findAllEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT;
        //    SqlDataReader reader = findAllEntertainments.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Entertainment e = new Entertainment
        //        {
        //            //genre = reader.GetString(reader.GetOrdinal("genre")),
        //            genre = "Action",
        //            title = reader.GetString(reader.GetOrdinal("title")),
        //            country = reader.GetString(reader.GetOrdinal("country")),
        //            language = reader.GetString(reader.GetOrdinal("language")),
        //            releaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate")),
        //            storyLine = reader.GetString(reader.GetOrdinal("storyLine")),
        //            //filmingLocation = reader.GetString(reader.GetOrdinal("filmingLocation")),
        //            filmingLocation = "Some place in the desert",
        //            information = reader.GetString(reader.GetOrdinal("information"))
        //        };

        //        temp.Add(e);

        //    }
        //    Console.WriteLine(temp.Count());
        //    Console.ReadLine();
        //    reader.Close();
        //    return temp;
        //}


        // Setup connection to database
        // Instantiate SqlConnection object with connectionstringcon = new SqlConnection(connectionString);
        // Write SQL query
        // Instantiate SqlCommand object with query string and SqlConnection objectstring queryString = "select * from tblProduct Order by name";SqlCommand readCommand = new SqlCommand(queryString, con);
        // Open connection con.Open();
        // Execure SqlCommand and assign read data to a SqlDataReader objectSqlDataReader productReader = readCommand.ExecuteReader();
        // Use data for the reader
        // E.g. convert read "rows" to domain objectint foundRows = PopulateProductList(productReader);
        // Close used resourcesproductReader.Close();

    }
}
