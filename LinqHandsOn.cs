using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LinqAssignment
{

    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int age { get; set; }
        public Person(string fName, string lName, int age)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }
    }
    public class LinqQuestions
    {

        //given datasets in questions

        int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
        string[] arr4 = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
        int[] arr5 = { 5, 7, 13, 24, 6, 9, 8, 7 };


        //solution to question 1
        public void HandsOn1()
        {
            var result = from d in n1 where d > 0 select d;
            Console.WriteLine("Positive  numbers in the list are:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //solution to question 2
        public void HandsOn2()
        {
            var result = from d in arr1
                         group d by d into a
                         select a;

            Console.WriteLine("The number and the Frequency are :");
            foreach (var item in result)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times");
            }
        }

        //solution to question 3
        public void HandsOn3()
        {
            Console.WriteLine("Enter string :");
            string input = Console.ReadLine();
            var result = from d in input
                         group d by d into a
                         select a;
            Console.WriteLine("The character and the Frequency are :");
            foreach (var item in result)
            {
                Console.WriteLine("Character " + item.Key + " : " + item.Count() + " times");
            }

        }

        //solution to question 4
        public void HandsOn4()
        {

            Console.WriteLine("Input starting character for the string: ");
            string start = Console.ReadLine();
            Console.WriteLine("Input ending character for the string: ");
            string end = Console.ReadLine();


            var result = from d in arr4
                         where d.StartsWith(start)
                         where d.EndsWith(end)
                         select d;
            Console.WriteLine("Cities startig and ending with the given words are:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        //solution to question 5
        public void HandsOn5()
        {
            var result = (from d in arr5 orderby d descending select d).Take(3).ToList();
            Console.WriteLine("the top n-th records :");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //solution to question 7,8,9
        public void HandsOn789()
        {
            var people = new List<Person>()
           {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

           };
            String Lstart = "D";
            var result1 = from d in people
                         where d.lName.StartsWith(Lstart)
                         select d;
            //var result2 = from d in people
            //             group d by d.lName.StartsWith(Lstart) into x
            //             select x;
            Console.WriteLine("Last names starting with D");
            foreach (var item in result1)
            {
                Console.WriteLine(item.lName);
            }

            //ans8
            Console.WriteLine("No. of people whose last name starts with D");
            Console.WriteLine(result1.Count());

            //ans9
            var result3 = from dd in people orderby dd.fName descending where dd.age > 40 select dd;
            Console.WriteLine("first Person Older Than 40 In Descending Alphabetical Order By First Name");
            foreach (var item in result3)  
            {
                Console.WriteLine(item.fName);
            }
        }

        //solution to question 10
        public void HandsOn10()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var result = from frList in fruits where frList.StartsWith("L") select frList;
            Console.WriteLine("words in the collection that start with the letter L: ");
            foreach (var item in result)
            { 
                Console.Write(item+"\t");
            }

        }

        //solution to question 11
        public void HandsOn11()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine("Multiples of 4 and 6 are :");
            var result = from mul in mixedNumbers where mul % 4 == 0 || mul % 6 == 0 select mul;
            foreach (var item in result)
            {
                Console.Write(item + "\t");
            }
        }

    }

    //solution to question 6
    public class Students
    {
        int StuId { get; set; }
        string StuName { get; set; }
        int GrPoint { get; set; }

        public void HandsOn6()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
            int maxGrPoint = Convert.ToInt32(Console.ReadLine());

            var result = (from studentData in stulist
                          group studentData by studentData.GrPoint into a
                          orderby a.Key descending
                          select new
                          {
                              newRecord = a.ToList()
                          }).ToList();
            result[maxGrPoint - 1].newRecord
                .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));


        }
    }
        

    }



