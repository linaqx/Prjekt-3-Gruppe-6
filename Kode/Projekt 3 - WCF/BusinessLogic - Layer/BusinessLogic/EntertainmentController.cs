using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic___Layer.BusinessLogic;
using Model___Layer.Model;
using Projekt_3___WCF.Model;
using WCF___library.DB;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___WCF.BusinessLogic
{
    public class EntertainmentController : IEntertainmentControllerIF
    {
        private EntertainmentDB edb;
        private readonly bool IsMovie = true;

        /// <summary>
        /// Constructer for EntertainmentController
        /// </summary>
        public EntertainmentController()
        {
            edb = new EntertainmentDB();
        }

        /// <summary>
        /// Findsall entertainments from database
        /// </summary>
        /// <returns>List<Entertainment></returns>
        public List<Entertainment> FindAllEntertainments()
        {
            return edb.GetAllEntertainments();
        }

        /// <summary>
        /// Find all personal Entertainments by user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List<Entertainment></returns>
        public List<Entertainment> FindPersonalEntertainments(int id)
        {
            return edb.GetPersonalEntertainments(id);
        }

        /// <summary>
        /// Get a list of all genres from database
        /// </summary>
        /// <returns>List<Genre></returns>
        public List<Genre> GetAllGenres()
        { 
            return edb.GetAllGenres();
        }

        /// <summary>
        /// Gets a list of all language from database
        /// </summary>
        /// <returns>List<Language></returns>
        public List<Language> GetAllLanguages()
        {
            return edb.GetAllLanguages();
        }

        /// <summary>
        /// Gets a alist of all countries from database
        /// </summary>
        /// <returns>List<Country></returns>
        public List<Country> GetAllCountries()
        {
            return edb.GetAllCountries();
        }
        
        /// <summary>
        /// Begins the transaction which inserts a movie into database
        /// </summary>
        /// <param name="m"></param>
        public void StartInsertMovieTransaction(Movie m)
        {
            m.IsMovie = IsMovie;
            edb.StartInsertMovieTransaction(m);
        }

        /// <summary>
        /// Gets a movie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Movie</returns>
        public Movie GetMovieById(int id)
        {
            return edb.GetMovieById(id);
        }

        /// <summary>
        /// Inserts a comment on a movie
        /// </summary>
        /// <param name="comment"></param>
        public void InsertComment(Comment comment)
        {
            edb.InsertComment(comment);
        }
    }
}