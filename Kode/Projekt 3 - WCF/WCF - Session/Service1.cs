using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogic___Layer.BusinessLogic;
using Projekt_3___WCF.Model;

namespace WCF___Session
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private SessionController SC;

        public Service1()
        {
            SC = new SessionController();
        }

        public User LoginConfirmation(User user)
        {
            return SC.LoginConfirmation(user);
        }
    }
}
