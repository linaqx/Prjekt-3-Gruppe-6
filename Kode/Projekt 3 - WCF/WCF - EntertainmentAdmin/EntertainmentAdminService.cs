using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model___Layer.Model;
using Projekt_3___WCF.BusinessLogic;
using Projekt_3___WCF.Model;

namespace WCF___EntertainmentAdmin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EntertainmentAdminService : IEntertainmentAdminService
    {
        private EntertainmentController EC;

        public EntertainmentAdminService()
        {
            EC = new EntertainmentController();
        }

        public List<Country> FindAllCountries()
        {
            return EC.GetAllCountries();
        }

        //public List<FilmingLocation> FindAllFilmingLocations()
        //{
        //    return EC.GetALLFilmingLocations();
        //}

        public List<Genre> FindAllGenre()
        {
            return EC.GetAllGenres();
        }

        public List<Language> FindAllLanguage()
        {
            return EC.GetAllLanguages();
        }

        public void StartInsertMovieTransaction(Movie m)
        {
            EC.StartInsertMovieTransaction(m);
        }
    }
}
