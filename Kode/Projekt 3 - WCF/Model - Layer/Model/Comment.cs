using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model___Layer.Model
{
    [DataContract]
    public class Comment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Entertainment_id { get; set; }
        [DataMember]
        public int User { get; set; }
        [DataMember]
        public string Message { get; set; }


        public Comment()
        {

        }
    }
}
