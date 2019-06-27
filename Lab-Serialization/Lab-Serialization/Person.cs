using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization;

namespace Lab_Serialization
{
    [DataContract]
    public class Person
    {
        [DataMember(Name = "first")]
        public string first { get; set; }
        [DataMember(Name = "last")]
        public string last { get; set; }
        [DataMember(Name = "age")]
        public int age { get; set; }
        Address Address;

          public Person()
        {
            first = null;
            last = null;
            age = 0;
            Address = new Address();
        }

    }
}
