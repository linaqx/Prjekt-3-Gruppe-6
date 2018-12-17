using Model___Layer.Model;
using Projekt_3___WCF.BusinessLogic;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___library
{
    
    public class EntertainmentService : IEntertainmentService
    {
        private EntertainmentController EC;

        /// <summary>
        /// Constructor for EntertainmentController
        /// </summary>
        public EntertainmentService()
        {
            EC = new EntertainmentController();
        }

        /// <summary>
        /// Finds all entertainments
        /// </summary>
        /// <returns>List<Entertainment></returns>
        public List<Entertainment> FindAllEntertainments()
        {
            return EC.FindAllEntertainments();
        }

        /// <summary>
        /// Finds all personal entertainments form databse by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>list<Entertainment></returns>
        public List<Entertainment> FindPersonalEntertainments(int id)
        {
            return EC.FindPersonalEntertainments(id);
        }

        /// <summary>
        /// Gets a movie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Movie</returns>
        public Movie GetMovieById(int id)
        {
            return EC.GetMovieById(id);
        }

        /// <summary>
        /// Inserts a comment
        /// </summary>
        /// <param name="comment"></param>
        public void InsertComment(Comment comment)
        {
            EC.InsertComment(comment);
        }
    }
}
