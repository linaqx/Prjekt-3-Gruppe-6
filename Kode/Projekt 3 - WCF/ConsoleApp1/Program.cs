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
            //MISSING!!!!!
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6");
            connection.Open();
            SqlCommand cmd = new SqlCommand("");
            SqlDataReader reader = cmd.ExecuteReader();
            

            while(reader.Read())
            {
                Console.WriteLine("");
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
