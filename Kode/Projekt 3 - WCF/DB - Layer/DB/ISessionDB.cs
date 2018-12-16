using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model___Layer.Model;
using Projekt_3___WCF.Model;

namespace DB___Layer.DB
{
    interface ISessionDB
    {
        User LoginConfirmation(string userName);
        Session FindSession(int person_id);
        int InsertSession(int id, string session_id);
        void LogOut(int person_id);
    }
}
