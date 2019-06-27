using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Lab_Serialization
{

    class Program
    {

        static void Main(string[] args)
        {
            Address a = new Address();
            a.City = "Farmingdale";
            a.state = "New York";
            Address b = new Address();
            b.City = "Amityville";
            b.state = "New York";
            string filename = "addr.json";

            List<Address> Addresses = new List<Address>();
            Addresses.Add(a);
            Addresses.Add(b);
            System.IO.FileStream writer = new FileStream(filename, FileMode.Create, FileAccess.Write);

            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(List<Address>));

            ser.WriteObject(writer, Addresses);
            writer.Close();
            
            Address c; // no need to call new
            String filename2 = "addr.json";
            FileStream reader = new FileStream(filename2, FileMode.Open, FileAccess.Read);




            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Address));



            c = (Address)inputSerializer.ReadObject(reader);
            reader.Close();
            
            //Console.WriteLine(b.city + " " + b.state);


            /* READING JSON
             * 
            Person p = new Person();

            p.first = "Jason";
            p.last = "Diaz";
            p.age = 100;
            filename = "person.json";

            System.IO.FileStream writer = new FileStream(filename, FileMode.Create, FileAccess.Write);

            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(Address));

            ser.WriteObject(writer, a);
            writer.Close();

            Person p2; // no need to call new
            String filename2 = "person.json";
            FileStream reader = new FileStream(filename2, FileMode.Open, FileAccess.Read);

                        
            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Person));



            p2 = (Person)inputSerializer.ReadObject(reader);
            reader.Close();
            */

        }
    }
}
