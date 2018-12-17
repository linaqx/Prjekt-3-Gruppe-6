using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlixNet.LogInSessionService;
using FlixNet.Models;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace FlixNet.ServiceLayer
{
    public class LogInService
    {
        private FlixNet.LogInSessionService.Service1Client logInSession;
        /// <summary>
        /// Constructor for LogInService
        /// </summary>
        public LogInService()
        {
            logInSession = new FlixNet.LogInSessionService.Service1Client();
        }

        /// <summary>
        /// Logs a user in by calling method LoginConfirmation form service
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Models.User </returns>
        public Models.User Login(Models.User user)
        {
            LogInSessionService.User u = ConvertToWCFUser(user);
            var loginUser = logInSession.LoginConfirmation(u);
            Models.User convertedUser = ConvertToModelUser(loginUser);

            return convertedUser;
        }

        /// <summary>
        /// Creates a FlixNet user from a service user
        /// </summary>
        /// <param name="wcfUser"></param>
        /// <returns>Mdels.User</returns>
        private Models.User ConvertToModelUser(LogInSessionService.User wcfUser)
        {
            Models.Session session = new Models.Session
            {
                Id = wcfUser.Session.Id,
                Session_id = wcfUser.Session.Session_id
            };

            Models.User user = new Models.User
            {
                Id = wcfUser.Id,
                UserName = wcfUser.UserName,
                Session = session
            };
            return user;
        }

        /// <summary>
        /// Creates a service.User from a FlixNet.User
        /// </summary>
        /// <param name="user"></param>
        /// <returns>LogInSessionService.User</returns>
        private LogInSessionService.User ConvertToWCFUser (Models.User user)
        {
            LogInSessionService.User wcfUser = new LogInSessionService.User
            {
                UserName = user.UserName,
                Password = user.Password
            };
            return wcfUser;
        }

        /// <summary>
        /// logout a user by setting password and úsername to null
        /// </summary>
        /// <param name="person_id"></param>
        public void Logout(int person_id)
        {
            logInSession.LogOut(person_id);
        }
    }
}