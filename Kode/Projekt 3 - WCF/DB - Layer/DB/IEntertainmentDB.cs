using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;
using WCF___library.DB;

namespace WCF___library.DB
{
    interface IEntertainmentDB
    {
        List<Entertainment> GetAllEntertainments();
    }
}
