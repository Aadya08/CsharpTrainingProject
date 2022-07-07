using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //int b;
            //int c;
            //a = 10;b = 10;
            //Console.WriteLine("Enter value a : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value b : ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Output : ");
            //c = a + b;
            //Console.WriteLine(c);       //displaying output
            //Console.Read();             //reading keyboard input
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Event eventObj = new Event();   //creating class instance
            //eventObj.CreateEvent();
            //eventObj.SelectEvents();
            //Customer custObj = new Customer();
            //custObj.CreateCustomer();
            //custObj.SelectCustomer();
            //Console.Read();

            //Movie movieObj = new Movie();
            //movieObj.CreateMovie();
            //movieObj.SelectMovie();
            //network networkLogobj = new network();
            //networkLogobj.NetworkLog();

            //Serialization serObj = new Serialization();
            //serObj.XmlSerialize();
            //serObj.XmlDeSerialize();

            //GenericsDemo gd = new GenericsDemo();
            //gd.ShowSalaryReport(400.2);
            //gd.ShowAgeReport(20);
            //gd.ShowGenderReport("female");
            //gd.ShowReport<int>(10);

            SerializationHandsOn obj = new SerializationHandsOn();
            //obj.XmlSerialize();

            //obj.XmlDeSerialize();
            obj.JsonSerialize();



            Console.Read();


        }
    }
}
