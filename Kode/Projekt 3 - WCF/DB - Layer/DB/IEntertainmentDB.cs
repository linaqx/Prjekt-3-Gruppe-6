using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model___Layer.Model;
using Projekt_3___WCF.Model;
using WCF___library.DB;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___library.DB
{
    interface IEntertainmentDB
    {
        List<Entertainment> GetAllEntertainments();
        void InsertComment(Comment comment);
    }
}
