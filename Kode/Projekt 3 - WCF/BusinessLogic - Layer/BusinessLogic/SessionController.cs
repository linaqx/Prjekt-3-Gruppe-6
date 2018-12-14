using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB___Layer.DB;
using Projekt_3___WCF.Model;

namespace BusinessLogic___Layer.BusinessLogic
{
    public class SessionController : ISessionController
    {
        private SessionDB sDB;
        public SessionController()
        {
            sDB = new SessionDB();
        }

        public User LoginConfirmation(User user)
        {
            User temp = new User();

            if (user.UserName != "" && user.Password != "")
            {
                User dbtemp = sDB.LoginConfirmation(user.UserName);

                if (dbtemp.UserName == user.UserName && dbtemp.Password == user.Password)
                {
                    User tempuser = new User
                    {
                        Id = dbtemp.Id,
                        UserName = dbtemp.UserName
                    };

                    temp = tempuser;
                }
            }

            //if (user.Id != 0)
            //{
            //    user. = Session(user);
            //}
            return temp;

        }

        private void Session(User user)
        {

        }
    }
}
