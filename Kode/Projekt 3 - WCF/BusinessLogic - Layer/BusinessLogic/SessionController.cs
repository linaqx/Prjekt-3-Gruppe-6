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

                    if (tempuser.Id != 0 && tempuser.Id > 0)
                    {
                        temp = Session(tempuser);
                    }
                }
            }

            return temp;

        }

        private User Session(User user)
        {
            long ticks = DateTime.Now.Ticks;
            byte[] bytes = BitConverter.GetBytes(ticks);
            string id = Convert.ToBase64String(bytes).Replace('+', '_').Replace('/', '-').TrimEnd('=');

            user.Session.Id = sDB.InsertSession(user.Id, id);
            user.Session.Session_id = id;

            return user;
        }
    }
}
