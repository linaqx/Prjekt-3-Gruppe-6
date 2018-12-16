using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB___Layer.DB;
using Projekt_3___WCF.Model;
using Model___Layer.Model;

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

                    //temp = tempuser;
                    if (tempuser.Id > 0)
                    {
                        temp = Session(tempuser);
                    }
                }
            }

            return temp;

        }

        public void LogOut(int person_id)
        {
            sDB.LogOut(person_id);
        }

        private User Session(User user)
        {
            user.Session = sDB.FindSession(user.Id);

            if (user.Session.Id == 0 && user.Session.Session_id == null)
            {
                long ticks = DateTime.Now.Ticks;
                byte[] bytes = BitConverter.GetBytes(ticks);
                string session_id = Convert.ToBase64String(bytes).Replace('+', '_').Replace('/', '-').TrimEnd('=');
                
                
                user.Session.Id = sDB.InsertSession(user.Id, session_id);
                user.Session.Session_id = session_id;
            }
            
            return user;
        }
    }
}
