using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EntertainmentDB
    {
        private string sql_FIND_ALL_ENTERTAINMENT = "select * from Entertainment;";
        private string sql_FIND_MOVIE_ENTERTAINMENT = "select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;";
        private string sql_FIND_SERIES_ENTERTAINMENT = "select * from Entertainment, Series where Series.entertainment_id = Entertainment.id;";
    }
}
