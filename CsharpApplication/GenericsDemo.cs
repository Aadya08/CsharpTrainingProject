using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplication
{
    internal class GenericsDemo
    {
        //public void ShowAgeReport(int age)
        //{
        //    Console.WriteLine(age);
        //}
        //public void ShowGenderReport(string gender)
        //{
        //    Console.WriteLine(gender);
        //}
        //public void ShowSalaryReport(double salary)
        //{
        //    Console.WriteLine(salary);
        //}
        public void ShowReport<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
