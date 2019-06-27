using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab_Serialization
{
    [DataContract]
    public class Address
    {
        [DataMember(Name ="City")]
        public string City { get; set; }
        [DataMember(Name = "state")]
        public string state { get; set; }
    }
}
