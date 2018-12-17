using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model___Layer.Model;
using Projekt_3___WCF.BusinessLogic;
using Projekt_3___WCF.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___EntertainmentAdmin
{
    
    public class EntertainmentAdminService : IEntertainmentAdminService
    {
        private EntertainmentController EC;

        /// <summary>
        /// Constructor for EntertainmentAdminService
        /// </summary>
        public EntertainmentAdminService()
        {
            EC = new EntertainmentController();
        }

        /// <summary>
        /// Finds all countires from database
        /// </summary>
        /// <returns>list<>Country</returns>
        public List<Country> FindAllCountries()
        {
            return EC.GetAllCountries();
        }

    
        /// <summary>
        /// Finds all genre from database
        /// </summary>
        /// <returns>list<Genre></returns>
        public List<Genre> FindAllGenre()
        {
            return EC.GetAllGenres();
        }

        /// <summary>
        /// Find all languages from database
        /// </summary>
        /// <returns>list<Language></returns>
        public List<Language> FindAllLanguage()
        {
            return EC.GetAllLanguages();
        }

        /// <summary>
        /// Starts the insert movie transaction
        /// </summary>
        /// <param name="m"></param>
        public void StartInsertMovieTransaction(Movie m)
        {
            EC.StartInsertMovieTransaction(m);
        }
    }
}
