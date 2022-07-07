using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //file handling

namespace CsharpApplication
{
    internal class Movie
    {
        string movieName, movieDesc, movieLang;
        int movieid;
        public void CreateMovie()
        {
            //Step1: creating new file
            FileStream fileStreamObj = new FileStream("C:\\testfileC\\movie.txt", FileMode.Create, FileAccess.Write);
            // use // or @ at beginning

            //Step2: writing a file
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            Console.WriteLine("Enter movie ID");
            movieid = Convert.ToInt32(Console.ReadLine());
            streamWriter.WriteLine("MovieID :" + movieid);

            Console.WriteLine("Enter movie name");
            movieName = Console.ReadLine();
            streamWriter.WriteLine("MovieName : "+ movieName);

            Console.WriteLine("Enter movie description");
            movieDesc = Console.ReadLine();
            streamWriter.WriteLine("MovieDesc : " + movieDesc);

            Console.WriteLine("Enter movie language");
            movieLang = Console.ReadLine();
            streamWriter.WriteLine("MovieLang : " + movieLang);
            
            streamWriter.Close();       //closing writing operation
            fileStreamObj.Close();      //closing file operation
            Console.WriteLine("File operation is completed");
            
        }

        public void SelectMovie()
        {
            FileStream fileStream = new FileStream("C:\\testfileC\\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            //streamreader obj reads one line at a time

            //Console.WriteLine(streamReaderObj.ReadToEnd());  //readline always returns string

            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());

            //declaring array
            //string[] myValues = new string[5];          //fixed
            while(streamReaderObj.Peek() > 0)
            {
                //Console.WriteLine(streamReaderObj.ReadLine());
                string line = streamReaderObj.ReadLine();
                string[] myStrs = line.Split(':');      //dynamic
                Console.WriteLine(myStrs[1]);
            }


            fileStream.Close();

        }
    }
}
