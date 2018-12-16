using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Projekt_3___WCF.Model;

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
        //[DataMember]
        //public Rating Rating { get; set; }


        public Comment()
        {
            
        }
    }
}
