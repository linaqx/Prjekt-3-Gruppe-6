using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntertainmentService = FlixNet.ServiceLibrary;
using FavoritListService = FlixNet.FavoriteListService;
using EntertainmentModel = FlixNet.Models;
using FlixNet.ServiceLibrary;

namespace FlixNet.ServiceLayer
{


    public class EntertainmentService
    {
        //Entertainment ent = new Entertainment();
        
        public List<EntertainmentModel.Entertainment> GetEntertainments()
        {
            FlixNet.ServiceLibrary.EntertainmentServiceClient sC = new EntertainmentServiceClient();


            var entertainments = sC.FindAllEntertainments();

            List<EntertainmentModel.Entertainment> convertedEnt = ConvertToModelEntertainment(entertainments);

            return convertedEnt;

        }

        private List<EntertainmentModel.Entertainment> ConvertToModelEntertainment(FlixNet.ServiceLibrary.Entertainment[] serviceEntertainments)
        {

            EntertainmentModel.Entertainment temp = null;
            List<EntertainmentModel.Entertainment> convertedEntertainments = new List<EntertainmentModel.Entertainment>();

            foreach (FlixNet.ServiceLibrary.Entertainment oldEnt in serviceEntertainments)
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

        private List<EntertainmentModel.FavoriteList> ConvertToModelFavoriteList(FlixNet.FavoriteListService.FavoriteList[] serviceFavoriteLists)
        {
            EntertainmentModel.FavoriteList temp = new EntertainmentModel.FavoriteList();
            List<EntertainmentModel.FavoriteList> convertedFavoriteList = new List<EntertainmentModel.FavoriteList>();

            foreach (FlixNet.FavoriteListService.FavoriteList oldFav in serviceFavoriteLists)
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



        public EntertainmentModel.Movie GetMovieById(int id)
        {
            ServiceLibrary.EntertainmentServiceClient sC = new ServiceLibrary.EntertainmentServiceClient();

            var movie = sC.GetMovieById(id);

            EntertainmentModel.Movie convertedMovie = ConvertToModelMovie(movie);

            return convertedMovie;
        }

        private EntertainmentModel.Movie ConvertToModelMovie(FlixNet.ServiceLibrary.Movie serviceEntertainments)
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
                Information = serviceEntertainments.Information,
                Comments = ConvertToModelComments(serviceEntertainments.Comments)

            };


            return convertedMovie;
        }



        private List<EntertainmentModel.Comment> ConvertToModelComments(FlixNet.ServiceLibrary.Comment[] ServiceComments)
        {
            List<EntertainmentModel.Comment> convertedComments = new List<EntertainmentModel.Comment>();

            foreach (FlixNet.ServiceLibrary.Comment oldCom in ServiceComments)
            {
                Models.User user = new Models.User
                {
                    Id = oldCom.User.Id,
                    UserName = oldCom.User.UserName
                };

                Models.Comment temp = new Models.Comment
                {
                    Id = oldCom.Id,
                    Entertainment_Id = oldCom.Entertainment_Id,
                    User = user,
                    Message = oldCom.Message
                };

                convertedComments.Add(temp);
            }
            return convertedComments;
        }

        public void InsertComment(Models.Comment c)
        {
            ServiceLibrary.EntertainmentServiceClient sC = new ServiceLibrary.EntertainmentServiceClient();
            ServiceLibrary.Comment comment = ConvertToWCFComments(c);
            sC.InsertComment(comment);
        }

        private ServiceLibrary.Comment ConvertToWCFComments(Models.Comment comment)
        {
            ServiceLibrary.Session session = new ServiceLibrary.Session
            {
                Session_id = comment.User.Session.Session_id
            };

            ServiceLibrary.User user = new ServiceLibrary.User
            {
                Id = comment.User.Id,
                Session = session
            };

            ServiceLibrary.Comment tempComment = new ServiceLibrary.Comment
            {
                Entertainment_Id = comment.Entertainment_Id,
                User = user,
                Message = comment.Message
            };

            return tempComment;
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