using Projekt_3___WCF.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF___library.DB;

namespace midlertidigTest
{
    class test
    {
        static void Main(string[] args)
        {
            EntertainmentDB edb = new EntertainmentDB();
            edb.GetEntertainments();
            DBConnection dBConnection = DBConnection.GetInstance();
            dBConnection.CloseConnection();
        }
    }
}
