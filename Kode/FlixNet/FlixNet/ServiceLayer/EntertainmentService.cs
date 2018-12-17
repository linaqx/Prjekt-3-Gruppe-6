using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntertainmentService = FlixNet.ServiceLibrary;
using FavoritListService = FlixNet.FavoriteListService;
using EntertainmentModel = FlixNet.Models;
using FlixNet.ServiceLibrary;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace FlixNet.ServiceLayer
{
    public class EntertainmentService
    {
        /// <summary>
        /// Gets All entertainments from server which gets from database
        /// </summary>
        /// <returnsList<EntertainmentModel.Entertainment>></returns>
        public List<EntertainmentModel.Entertainment> GetEntertainments()
        {
            FlixNet.ServiceLibrary.EntertainmentServiceClient sC = new EntertainmentServiceClient();
            var entertainments = sC.FindAllEntertainments();
            List<EntertainmentModel.Entertainment> convertedEnt = ConvertToModelEntertainment(entertainments);

            return convertedEnt;
        }
        /// <summary>
        /// Converts serviceLibrary Entertainments objects from service reference to flixNet.model Entertainment objects
        /// </summary>
        /// <param name="serviceEntertainments"></param>
        /// <returns>List<EntertainmentModel.Entertainment></returns>
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

                convertedEntertainments.Add(temp);
            }
            return convertedEntertainments;
        }

        /// <summary>
        /// Gets favoritelist objects for a specific user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List<EntertainmentModel.FavoriteList></returns>
        public List<EntertainmentModel.FavoriteList> GetFavoriteLists(int id)
        {
            FavoritListService.Service1Client fls = new FavoritListService.Service1Client();
            var FavoriteLists = fls.FindAllListByUser(id);
            List<EntertainmentModel.FavoriteList> convertedFavoriteList = ConvertToModelFavoriteList(FavoriteLists);

            return convertedFavoriteList;
        }

        /// <summary>
        /// Converts serviceLibrary favoritelist to flixNet models FavoriteList
        /// </summary>
        /// <param name="serviceFavoriteLists"></param>
        /// <returns>List<EntertainmentModel.FavoriteList></returns>
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

        /// <summary>
        /// Returns a specific movie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>EntertainmentModel.Movie</returns>
        public EntertainmentModel.Movie GetMovieById(int id)
        {
            ServiceLibrary.EntertainmentServiceClient sC = new ServiceLibrary.EntertainmentServiceClient();
            var movie = sC.GetMovieById(id);
            EntertainmentModel.Movie convertedMovie = ConvertToModelMovie(movie);

            return convertedMovie;
        }

        /// <summary>
        /// Converts a specific service Movie to FlixNet models Movie 
        /// </summary>
        /// <param name="serviceEntertainments"></param>
        /// <returns>EntertainmentModel.Movie </returns>
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

        /// <summary>
        /// Converts a service Comment to a FlixNet comment, and returns a list of comments
        /// </summary>
        /// <param name="ServiceComments"></param>
        /// <returns>List<EntertainmentModel.Comment></returns>
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

        /// <summary>
        /// Inserts a Comment object on a specific movie
        /// </summary>
        /// <param name="c"></param>
        public void InsertComment(Models.Comment c)
        {
            ServiceLibrary.EntertainmentServiceClient sC = new ServiceLibrary.EntertainmentServiceClient();
            ServiceLibrary.Comment comment = ConvertToWCFComments(c);
            sC.InsertComment(comment);
        }

        /// <summary>
        /// Converts FlixNet comment to service Comment so that 
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>ServiceLibrary.Comment</returns>
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
    }

}