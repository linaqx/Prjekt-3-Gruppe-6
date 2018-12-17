using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogic___Layer.BusinessLogic;
using Projekt_3___WCF.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___Session
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private SessionController SC;

        /// <summary>
        /// constructor for service1
        /// </summary>
        public Service1()
        {
            SC = new SessionController();
        }

        /// <summary>
        /// checks if user exist in database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>user</returns>
        public User LoginConfirmation(User user)
        {
            return SC.LoginConfirmation(user);
        }

        /// <summary>
        /// Log an user out of the system
        /// </summary>
        /// <param name="person_id"></param>
        public void LogOut(int person_id)
        {
            SC.LogOut(person_id);
        }
    }
}
