using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using FavoriteListService;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Host
{
    class Program
    {
        /// <summary>
        /// Main method to run host
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Console based host");

            using (ServiceHost serviceHostSession = new ServiceHost(typeof(WCF___Session.Service1)))
            using (ServiceHost serviceHostEntertainmentAdmin = new ServiceHost(typeof(WCF___EntertainmentAdmin.EntertainmentAdminService)))
            using (ServiceHost serviceHostEntertainments = new ServiceHost(typeof(WCF___library.EntertainmentService)))
            using (ServiceHost serviceHostFavoriteList = new ServiceHost(typeof(Service1)))
            {
                // Open the host ans start listening for incoming calls
                serviceHostSession.Open();
                DisplayHostInfo(serviceHostSession);

                serviceHostEntertainmentAdmin.Open();
                DisplayHostInfo(serviceHostEntertainmentAdmin);

                serviceHostEntertainments.Open();
                DisplayHostInfo(serviceHostEntertainments);

                serviceHostFavoriteList.Open();
                DisplayHostInfo(serviceHostFavoriteList);

                // Keep the service running until the Enter key is pressed
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");

                Console.ReadLine();

                serviceHostSession.Close();
                serviceHostEntertainmentAdmin.Close();
                serviceHostEntertainments.Close();
                serviceHostFavoriteList.Close();

            }
        }

        /// <summary>
        /// Displays host information in cmd
        /// </summary>
        /// <param name="host"></param>
        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("*-- Host Info --*");

            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"Address: {se.Address}");
                Console.WriteLine($"Binding: {se.Binding.Name}");
                Console.WriteLine($"Contract: {se.Contract.Name}");
            }
            Console.WriteLine("*---------------*");
        }
    }
}


