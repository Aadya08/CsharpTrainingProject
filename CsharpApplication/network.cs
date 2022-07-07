using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpApplication
{
    internal class network
    {
       public void NetworkLog()
        {
            FileStream fileStream = new FileStream("C:\\testfileC\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            
            Console.WriteLine("ID" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date" + "\t\t\t" + "Status" + "\t" + "Network");
            while (reader.Peek() > 0)
            {
                
                string line = reader.ReadLine();
                int len = line.Length;

                if (line != "") {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Date")
                    {
                        Console.Write(myStrs[1] + ":" + myStrs[2] + ":" + myStrs[3].Remove(2)+"\t");
                    }
                    else {
                        Console.Write(myStrs[1] + "\t");
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("\t");
                }
                
            }
        }
    }
}
