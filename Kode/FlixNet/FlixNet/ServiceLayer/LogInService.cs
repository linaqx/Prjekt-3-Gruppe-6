using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlixNet.LogInSessionService;
using FlixNet.Models;

namespace FlixNet.ServiceLayer
{
    public class LogInService
    {
        private FlixNet.LogInSessionService.Service1Client logInSession;

        public LogInService()
        {
            logInSession = new FlixNet.LogInSessionService.Service1Client();
            
        }
    
        public Models.User Login(Models.User user)
        {

            LogInSessionService.User u = ConvertToWCFUser(user);
            var henning = logInSession.LoginConfirmation(u);
            Models.User hennigsMor = ConvertToModelUser(henning);

            return hennigsMor;
        }

        //laver en WCF user om til en web user
        private Models.User ConvertToModelUser(LogInSessionService.User wcfUser)
        {

            Models.User user = new Models.User
            {
                Id = wcfUser.Id,
                UserName = wcfUser.UserName
            };


            return user;
        }

        //laver en WEB user om til en WCF user
        private LogInSessionService.User ConvertToWCFUser (Models.User user)
        {
            LogInSessionService.User wcfUser = new LogInSessionService.User
            {
                UserName = user.UserName,
                Password = user.Password
            };


            return wcfUser;
        }
    }
}