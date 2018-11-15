using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6;Integrated security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("select name from [Projekt3_Gruppe6].[dbo].[Country]", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            

            while(reader.Read())
            {

                Console.WriteLine("");

                Console.WriteLine("{0}", reader.GetString(0));

            }
            reader.Close();
            connection.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }
    }
}
