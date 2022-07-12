using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LinqAssignment
{

    public class Customer
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public double Balance { get; set; }

    }
    public class LinqAssignment2Solutions
    {
        //solution to question 2 assignment 2
        public void HandsOn12()
        {
            Console.WriteLine("Return most frequent character in string");
            Console.WriteLine("Enter string :");
            string inputString = Console.ReadLine();
            var result = from data in inputString group data by data into a orderby a.Count() descending select a;
            Console.WriteLine(result.First().Key);
        }

        //solution to question 3 assignment 2
        public void HandsOn13()
        {
            List<string> nonDupe = new List<string>() { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };
            Console.WriteLine("return a list that contains only unique (non-duplicate) strings");
            var result = from data in nonDupe group data by data into a orderby a.Count() select a;
            foreach (var item in result)
            {
                if(item.Count() == 1)
                Console.WriteLine(item.Key);
            }

        }

        //solution to question 4 assignment 2
        public void HandsOn14()
        {
            List<int> descList = new List<int>() { 78, -9, 0, 23, 54, 21, 7, 86 };
            Console.WriteLine("query that returns top 5 numbers from the list of integers in descending order");
            var result = (from data in descList orderby data descending select data).Take(5);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //solution to question 5 assignment 2
        public void HandsOn15()
        {
            List<string> newfruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var result = from frList in newfruits where frList.StartsWith("L") select frList;
            Console.WriteLine("words in the collection that start with the letter L: ");
            foreach (var item in result)
            {
                Console.Write(item + "\t");
            }
        }
        //question 6 repeated
        //solution to question 7 in assignment 2
        public void HandsOn16()
        {
            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };
            Console.WriteLine("Output how many numbers are in this list");
            var res = from d in numbers select d;
            Console.WriteLine("No. of items : " + res.Count());
           

        }

        //solution to question 8 in assignment 2
        public void HandsOn17()
        {
            List<double> purchases = new List<double>(){2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65};
            Console.WriteLine("Total amount of money :");
            var res = (from d in purchases select d).Sum();
            Console.WriteLine(Convert.ToDouble(res)); 

        }

        //solution to question 9 in assignment 2
        public void HandsOn18()
        {
            List<double> prices = new List<double>(){ 879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76};
            var res = (from d in prices select d).Max();
            Console.WriteLine("Most expensive product costs : rs. "+res);

        }

        //solution to question 10,11 in assignment 2
        public void HandsOn1920()
        {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };
            Console.WriteLine("No. of millioniares per bank");
            var res1 = from cust in customers where cust.Balance > 1000000.00 group cust by cust.Bank into a select a;
            foreach(var item in res1)
            {
                Console.WriteLine(item.Key + "\t" + item.Count());
            }
            Console.WriteLine("Displaying Top 3 customers per bank");
            var res2 = (from cust in customers group cust by cust.Bank into a orderby a descending select a).Take(3);
            foreach (var item in res2)
            {
                Console.WriteLine(item.Key + "\t" + item.Count());
            }
        }


    }
}
