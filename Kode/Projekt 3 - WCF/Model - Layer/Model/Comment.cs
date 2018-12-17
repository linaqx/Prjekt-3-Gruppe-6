using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Model___Layer.Model
{

    [DataContract]
    public class Comment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Entertainment_Id { get; set; }
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public string Message { get; set; }


        /// <summary>
        /// Constructor for Comment
        /// </summary>
        public Comment()
        {
            
        }
    }
}
