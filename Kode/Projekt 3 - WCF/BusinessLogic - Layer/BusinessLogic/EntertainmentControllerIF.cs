using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model___Layer.Model;
using Projekt_3___WCF.Model;

namespace BusinessLogic___Layer.BusinessLogic
{
    interface EntertainmentControllerIF
    {
        Entertainment FindEntertainmentByName(List<Entertainment> e);

        List<Entertainment> FindAllEntertainments();

        List<Entertainment> FindPersonalEntertainments(int id);

        List<Genre> GetAllGenres();

        List<FilmingLocation> GetALLFilmingLocations();

        List<Language> GetAllLanguages();

        List<Country> GetAllCountries();

        void StartInsertMovieTransaction(Movie m);

        
    }
}
