using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;

namespace BusinessLogic___Layer.BusinessLogic
{
    interface ISessionController
    {
        User LoginConfirmation(User user);
        void LogOut(int person_id);
    }
}
