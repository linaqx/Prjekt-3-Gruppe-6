using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model___Layer.Model
{
    [DataContract]
    public class Session
    {
        
        [DataMember]
        public string Session_id { get; set; }

        public Session()
        {

        }
    }
}
