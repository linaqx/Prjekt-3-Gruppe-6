using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic___Layer.BusinessLogic;
using Model___Layer.Model;
using Projekt_3___WCF.Model;
using WCF___library.DB;

namespace Projekt_3___WCF.BusinessLogic
{
    public class EntertainmentController : IEntertainmentControllerIF
    {
        private EntertainmentDB edb;
        private readonly bool IsMovie = true;

        public EntertainmentController()
        {
            edb = new EntertainmentDB();
        }

        public List<Entertainment> FindAllEntertainments()
        {
            return edb.GetAllEntertainments();
        }

        public List<Entertainment> FindPersonalEntertainments(int id)
        {
            return edb.GetPersonalEntertainments(id);
        }

        public List<Genre> GetAllGenres()
        { 
            return edb.GetAllGenres();
        }

        public List<Language> GetAllLanguages()
        {
            return edb.GetAllLanguages();
        }

        public List<Country> GetAllCountries()
        {
            return edb.GetAllCountries();
        }

        public void StartInsertMovieTransaction(Movie m)
        {
            m.IsMovie = IsMovie;
            edb.StartInsertMovieTransaction(m);
        }

        public Movie GetMovieById(int id)
        {
            return edb.GetMovieById(id);
        }

        public void InsertComment(Comment comment)
        {
            edb.InsertComment(comment);
        }
    }
}