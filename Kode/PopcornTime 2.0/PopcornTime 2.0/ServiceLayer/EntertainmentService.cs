using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntertainmentService = PopcornTime_2._0.EntertainmentService1;
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
            //EntertainmentService1.EntertainmentServiceClient sC = new EntertainmentService1.EntertainmentServiceClient();
            //List<PopcornTime_2._0.EntertainmentService1.Entertainment> tempold = new List<EntertainmentService1.Entertainment>();
            //tempold = sC.FindAllEntertainments();

            EntertainmentModel.Entertainment temp = null;
            List<EntertainmentModel.Entertainment> convertedEntertainments = new List<EntertainmentModel.Entertainment>();

            

            foreach (PopcornTime_2._0.EntertainmentService1.Entertainment oldEnt in serviceEntertainments)
            {
                oldEnt.
                //temp = new Models.Entertainment()
                //{
                //    Id = oldEnt.Id

                //};
                
                temp = new EntertainmentModel.Entertainment(oldEnt.Id, oldEnt.genre, oldEnt.title, oldEnt.country, oldEnt.language, oldEnt.releaseDate, oldEnt.storyLine, oldEnt.filmingLocation, oldEnt.information );
                //temp.id = oldEnt.Id;
                //temp.genre = oldEnt.genre;
                

                //lav den nye entertainment type udfra den gamle
                // 
                convertedEntertainments.Add(temp);
            }

            return convertedEntertainments;
        }


        //public Models.Entertainment entertainment
        //{
        //    return entertainment.title.get();
        //}

        public string title { get;  set; }
        public DateTime releaseDate { get; set; }
    }

}