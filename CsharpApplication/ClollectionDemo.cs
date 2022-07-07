using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CsharpApplication
{
    internal class ClollectionDemo
    {
        public void data()
        {
            string[] values = new string[3];
            values[0] = "1";
            values[1] = "test1";
            values[2] = "40.9";

            ArrayList arrayListObj = new ArrayList();
            arrayListObj.Add("test1");
            arrayListObj.Add(1);
            arrayListObj.Add(40.9);

            foreach(var item in arrayListObj)       //var item in <collection>
            {
                Console.WriteLine(item);            //array.length => collection.count
            }
        }
        

    }
}
