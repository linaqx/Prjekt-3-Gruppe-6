using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntertainmentService = PopcornTime_2._0.EntertainmentService1;
using FavoritListService = PopcornTime_2._0.FavoritList;
using EntertainmentModel = PopcornTime_2._0.Models;

namespace PopcornTime_2._0.ServiceLayer
{


    public class EntertainmentService
    {
        //Entertainment ent = new Entertainment();

        public List<EntertainmentModel.Entertainment> GetEntertainments()
        {

            EntertainmentService1.EntertainmentServiceClient sC = new EntertainmentService1.EntertainmentServiceClient();

            var entertainments = sC.FindAllEntertainments();

            List<EntertainmentModel.Entertainment> convertedEnt = ConvertToModelEntertainment(entertainments);

            return convertedEnt;

        }

        private List<EntertainmentModel.Entertainment> ConvertToModelEntertainment(PopcornTime_2._0.EntertainmentService1.Entertainment[] serviceEntertainments)
        {

            EntertainmentModel.Entertainment temp = null;
            List<EntertainmentModel.Entertainment> convertedEntertainments = new List<EntertainmentModel.Entertainment>();

            foreach (PopcornTime_2._0.EntertainmentService1.Entertainment oldEnt in serviceEntertainments)
            {

                temp = new Models.Entertainment()
                {
                    Id = oldEnt.Id,
                    Title = oldEnt.Title,
                    ReleaseDate = oldEnt.ReleaseDate
                };

                //temp = new EntertainmentModel.Entertainment(oldEnt.Id, oldEnt.genre, oldEnt.title, oldEnt.country, oldEnt.language, oldEnt.releaseDate, oldEnt.storyLine, oldEnt.filmingLocation, oldEnt.information );
                convertedEntertainments.Add(temp);
            }
            return convertedEntertainments;
        }

        public List<EntertainmentModel.FavoriteList> GetFavoriteLists(int id)
        {
            FavoritListService.Service1Client fls = new FavoritListService.Service1Client();


            var FavoriteLists = fls.FindAllListByUser(id);

            List<EntertainmentModel.FavoriteList> convertedFavoriteList = ConvertToModelFavoriteList(FavoriteLists);

            return convertedFavoriteList;

        }

        private List<EntertainmentModel.FavoriteList> ConvertToModelFavoriteList(PopcornTime_2._0.FavoritList.FavoriteList[] serviceFavoriteLists)
        {
            EntertainmentModel.FavoriteList temp = new EntertainmentModel.FavoriteList();
            List<EntertainmentModel.FavoriteList> convertedFavoriteList = new List<EntertainmentModel.FavoriteList>();

            foreach (PopcornTime_2._0.FavoritList.FavoriteList oldFav in serviceFavoriteLists)
            {

                EntertainmentModel.FavoriteList temp1 = new Models.FavoriteList
                {
                    Id = oldFav.Id,
                    Author = oldFav.Author,
                    Name = oldFav.Name,
                    Description = oldFav.Description,
                    
                    
                };
                temp = temp1;
                convertedFavoriteList.Add(temp);
            }
            

            return convertedFavoriteList;

        }

        public EntertainmentModel.Movie MovieById(int id)
        {
            EntertainmentService1.EntertainmentServiceClient sC = new EntertainmentService1.EntertainmentServiceClient();

            var movie = sC.GetMovieById(id);

            EntertainmentModel.Movie convertedMovie = ConvertToModelMovie(movie);

            return convertedMovie;
        }

        private EntertainmentModel.Movie ConvertToModelMovie(PopcornTime_2._0.EntertainmentService1.Movie serviceEntertainments)
        {
            EntertainmentModel.Language language = new EntertainmentModel.Language
            {
                Id = serviceEntertainments.Language.Id,
                Name = serviceEntertainments.Language.Name
            };

            EntertainmentModel.Genre genre = new EntertainmentModel.Genre
            {
                Id = serviceEntertainments.Genre.Id,
                Name = serviceEntertainments.Genre.Name
            };

            EntertainmentModel.Country country = new EntertainmentModel.Country
            {
                Id = serviceEntertainments.Country.Id,
                Name = serviceEntertainments.Country.Name
            };


            EntertainmentModel.Movie convertedMovie = new EntertainmentModel.Movie
            {
                Id = serviceEntertainments.Id,
                Genre = genre,
                Title = serviceEntertainments.Title,
                Country = country,
                Language = language,
                ReleaseDate = serviceEntertainments.ReleaseDate,
                StoryLine = serviceEntertainments.StoryLine,
                FilmingLocation = serviceEntertainments.FilmingLocation,
                Information = serviceEntertainments.Information

            };

        


            return convertedMovie;
        }


        //private List<Models.Entertainment> entertainments(PopcornTime_2._0.FavoritList.FavoriteList FavObject)
        //{
        //    PopcornTime_2._0.FavoritList.FavoriteList f1 = new FavoritListService.FavoriteList();

        //    EntertainmentModel.Entertainment temp = null;
        //    //formål returner en 



        //    List<EntertainmentModel.Entertainment> convertedEntertainments = new List<EntertainmentModel.Entertainment>();

        //    foreach (PopcornTime_2._0.EntertainmentService1.Entertainment oldEnt in serviceEntertainments)
        //    {

        //        temp = new Models.Entertainment()
        //        {
        //            Id = oldEnt.Id,
        //            Title = oldEnt.Title,
        //            ReleaseDate = oldEnt.ReleaseDate
        //        };

        //        //temp = new EntertainmentModel.Entertainment(oldEnt.Id, oldEnt.genre, oldEnt.title, oldEnt.country, oldEnt.language, oldEnt.releaseDate, oldEnt.storyLine, oldEnt.filmingLocation, oldEnt.information );
        //        convertedEntertainments.Add(temp);
        //    }
        //    return convertedEntertainments;

        //    return null;
        //}


    }

}