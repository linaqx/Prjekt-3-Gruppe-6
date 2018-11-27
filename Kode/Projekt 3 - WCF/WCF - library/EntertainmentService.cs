﻿using Projekt_3___WCF.BusinessLogic;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF___library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EntertainmentService : IEntertainmentService
    {
        private EntertainmentController EC;

        public EntertainmentService()
        {
            EC = new EntertainmentController();
        }

        //public string GetData(string value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public List<Entertainment> FindAllEntertainments()
        {
            return EC.FindAllEntertainments();

        }

        public List<Entertainment> FindPersonalEntertainments(int id)
        {
            return EC.FindPersonalEntertainments(id);
        }
    }
}