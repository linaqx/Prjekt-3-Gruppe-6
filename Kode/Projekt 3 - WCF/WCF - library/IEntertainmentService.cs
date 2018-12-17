using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projekt_3___WCF.Model;
using Model___Layer.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEntertainmentService
    {
        [OperationContract]
        List<Entertainment> FindAllEntertainments();

        [OperationContract]
        List<Entertainment> FindPersonalEntertainments(int id);

        [OperationContract]
        Movie GetMovieById(int id);

        [OperationContract]
        void InsertComment(Comment comment);

    }
}
