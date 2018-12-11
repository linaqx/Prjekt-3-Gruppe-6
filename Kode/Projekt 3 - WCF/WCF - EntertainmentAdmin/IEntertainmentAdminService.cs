using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model___Layer.Model;
using Projekt_3___WCF.Model;

namespace WCF___EntertainmentAdmin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEntertainmentAdminService
    {
        [OperationContract]
        List<Genre> FindAllGenre();

        //[OperationContract]
        //List<FilmingLocation> FindAllFilmingLocations();

        [OperationContract]
        List<Language> FindAllLanguage();

        [OperationContract]
        List<Country> FindAllCountries();

        [OperationContract]
        void StartInsertMovieTransaction(Movie m);

    }
}
