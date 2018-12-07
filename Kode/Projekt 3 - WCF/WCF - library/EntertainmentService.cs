using Model___Layer.Model;
using Projekt_3___WCF.BusinessLogic;
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

        public List<Country> FindAllCountries()
        {
            return EC.GetAllCountries();
        }

        public List<Entertainment> FindAllEntertainments()
        {
            return EC.FindAllEntertainments();

        }

        public List<FilmingLocation> FindAllFilmingLocations()
        {
            return EC.GetALLFilmingLocations();
        }

        public List<Genre> FindAllGenre()
        {
            return EC.GetAllGenres();
        }

        public List<Language> FindAllLanguage()
        {
            return EC.GetAllLanguages();
        }

        public List<Entertainment> FindPersonalEntertainments(int id)
        {
            return EC.FindPersonalEntertainments(id);
        }

        public Movie GetMovieById(int id)
        {
            return EC.GetMovieById(id);
        }

        public void StartInsertMovieTransaction(Movie m)
        {
            EC.StartInsertMovieTransaction(m);
        }
    }
}
