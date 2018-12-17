using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB___Layer.DB;
using Projekt_3___WCF.Model;
using Model___Layer.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace BusinessLogic___Layer.BusinessLogic
{
    public class SessionController : ISessionController
    {
        private SessionDB sDB;

        /// <summary>
        /// Constructor for SessionController
        /// </summary>
        public SessionController()
        {
            sDB = new SessionDB();
        }

        /// <summary>
        /// Confirms a user exist in database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User </returns>
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
                    
                    if (tempuser.Id > 0)
                    {
                        temp = Session(tempuser);
                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// Log the user out of system
        /// </summary>
        /// <param name="person_id"></param>
        public void LogOut(int person_id)
        {
            sDB.LogOut(person_id);
        }

        /// <summary>
        /// Generates a session for a specific user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User</returns>
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
