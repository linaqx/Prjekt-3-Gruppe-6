using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EntertainmentDB
    {
        private readonly string sql_FIND_ALL_ENTERTAINMENT = "select * from Entertainment;";
        private readonly string sql_FIND_MOVIE_ENTERTAINMENT = "select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;";
        private readonly string sql_FIND_SERIES_ENTERTAINMENT = "select * from Entertainment, Series where Series.entertainment_id = Entertainment.id;";


        private string FindAllEntertainments;
        //con = new SqlConnection(connectionString);
        //Navn skal findes i App.Config eller DBConnection
        //private string _ConnectionString = ConfigurationManager.ConnectionStrings["Navn"].ConnectionString;

        public EntertainmentDB()
        {
            //statement
            FindAllEntertainments.CommandText = "SELECT * FROM Entertainment";

        }

        public List<Entertainment> GetEntertainments()
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {



                }

            }

        }

        //byg entertainments
        private List<Entertainment> buildEntertainment(SqlDataReader dr)
        {
            List<Entertainment> temp = new List<Entertainment>();
            try
            {

                while (dr.)
                {
                    Entertainment e = FindAllEntertainments(rs.getInt("fabric_id"));
                    Roll roll = buildRoll(rs, fab);
                    temp.add(e);
                }
            }
            catch (SQLException e)
            {
                e.printStackTrace();
            }
            return temp;
        }


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
