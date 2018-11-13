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
<<<<<<< HEAD
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6");
            connection.Open();
            SqlCommand cmd = new SqlCommand("");
=======
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Projekt3_Gruppe6;Integrated security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("select name from [Projekt3_Gruppe6].[dbo].[Country]", connection);
>>>>>>> b121f66433e6baa0d5adfe6aeac99220f4e59c05
            SqlDataReader reader = cmd.ExecuteReader();
            

            while(reader.Read())
            {
<<<<<<< HEAD
                Console.WriteLine("");
=======
                Console.WriteLine("{0}", reader.GetString(0));
>>>>>>> b121f66433e6baa0d5adfe6aeac99220f4e59c05
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
