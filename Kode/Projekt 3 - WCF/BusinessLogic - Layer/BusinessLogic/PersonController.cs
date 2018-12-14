using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic___Layer.BusinessLogic;
using Projekt_3___WCF.Model;
using WCF___library.DB;

namespace Projekt_3___WCF.BusinessLogic
{
    public class PersonController : IPersonController 
    {
        private PersonDB pDB;

        public PersonController()
        {
            pDB = new PersonDB();
        }

        public User LoginConfirmation(User user)
        {
            User temp = new User();
            
            if (user.UserName != "" || user.Password != "")
            {
                User dbtemp = pDB.LoginConfirmation(user.UserName);

                if (dbtemp.UserName == user.UserName || dbtemp.Password == user.Password)
                {
                    temp = new User
                    {
                        Id = user.Id,
                        UserName = user.UserName
                    };
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