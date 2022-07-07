using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;


namespace CsharpApplication
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }

    }
    internal class SerializationHandsOn
    {

        //Person per = new Person
        //{
        //    name = "Aadya",
        //    age = 22,
        //    city = "Blr"
        //};

        

        public void XmlSerialize()
        {
            Person per = new Person();
            Console.Write("Enter name ");
            per.name = Console.ReadLine();
            Console.Write("Enter age ");
            per.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter city ");
            per.city = Console.ReadLine();


            XmlSerializer xs = new XmlSerializer(typeof(Person));    
            TextWriter txt = new StreamWriter(@"C:\testfileC\SerializationHandsOn.xml");
            xs.Serialize(txt, per);      
            txt.Close();
        }
        public void XmlDeSerialize()        
        {
            Person per = new Person();
            XmlSerializer xs = new XmlSerializer(typeof(Person));     
            StreamReader reader = new StreamReader(@"C:\testfileC\SerializationHandsOn.xml");
            per = (Person)xs.Deserialize(reader);     
            Console.WriteLine("Handson results");
            Console.WriteLine(per.name + "\t" + per.age + "\t" + per.city);
        }
        public void JsonSerialize()
        {

            //var person = new Person
            //{
            //    name = Console.ReadLine(),

            //    age = Convert.ToInt32(Console.ReadLine()),

            //    city = Console.ReadLine()
            //};
            Person per = new Person();
            Console.Write("Enter name ");
            per.name = Console.ReadLine();
            Console.Write("Enter age ");
            per.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter city ");
            per.city = Console.ReadLine();


            string jsonString = JsonSerializer.Serialize(per); //xml to json
            Console.WriteLine(jsonString);
            var obj = JsonSerializer.Deserialize<Person>(jsonString);
            //Console.WriteLine(obj.name + " " + obj.age + " " + obj.city);

        }
    }
}
