using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Model___Layer.Model
{
    [DataContract]
    public class Session
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Session_id { get; set; }

        /// <summary>
        /// Constructor for Session
        /// </summary>
        public Session()
        {

        }
    }
}
