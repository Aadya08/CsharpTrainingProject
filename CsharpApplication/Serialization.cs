using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
//using Newtonsoft.Json;
using System.Text.Json;


//serialization
//*XmlSerialization
//*JsonSerialization
//*SoapSerialization
//convert from object to json/xml/soap to transfer data over network

namespace CsharpApplication
{

    

    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }

    }
    public class Employee
    {
        public int Id = 1;
        public string name = "John Smith";
        public string subject = "Physics";
    }
    internal class Serialization
    {
        public void JsonSerialize()
        {
            //creating onj and accessing properties - new method
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine(obj.Date + " " + obj.TemperatureCelsius + " " + obj.Summary);

        }
        public void XmlSerialize()
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));     //passing Employee class and not object
            TextWriter txt = new StreamWriter(@"C:\testfileC\Serialization.xml");
            xs.Serialize(txt, bs);      //writing obj through textwriter
            txt.Close();
        }
        public void XmlDeSerialize()        //xml to object to display on ui
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));     //passing Employee class and not object
            StreamReader reader = new StreamReader(@"C:\testfileC\Serialization.xml");
            bs = (Employee)xs.Deserialize(reader);     //writing obj through textwriter
            Console.WriteLine("Employee details");
            Console.WriteLine(bs.name+" "+bs.Id+" "+bs.subject);
        }


    }
}
