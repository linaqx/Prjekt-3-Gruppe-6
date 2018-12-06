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

        public List<EntertainmentModel.FavoriteList> GetFavoriteLists()
        {
            FavoritListService.Service1Client fls = new FavoritListService.Service1Client();


            var FavoriteLists = fls.FindAllListByUser(1);

            List<EntertainmentModel.FavoriteList> convertedFavoriteList = ConvertToModelFavoriteList(FavoriteLists);

            return convertedFavoriteList;

        }

        private List<EntertainmentModel.FavoriteList> ConvertToModelFavoriteList(PopcornTime_2._0.FavoritList.FavoriteList[] serviceFavoriteLists)
        {
            EntertainmentModel.FavoriteList temp = null;
            List<EntertainmentModel.FavoriteList> convertedFavoriteList = new List<EntertainmentModel.FavoriteList>();

            foreach (PopcornTime_2._0.FavoritList.FavoriteList oldFav in serviceFavoriteLists)
            {

                temp = new Models.FavoriteList()
                {
                    Author = oldFav.Author,
                    Name = oldFav.Name,
                    Description = oldFav.Description,
                    Entertainments = oldFav.Entertainments;
            };
        
            convertedFavoriteList.Add(temp);

                return convertedFavoriteList;
            
        }


    }

}