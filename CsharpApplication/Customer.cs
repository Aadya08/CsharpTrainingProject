using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplication
{
    
    public class Customer
    {
        string custName, custAdd, custEmail;
        int mobile;
        public void CreateCustomer()
        {
            Console.WriteLine("Customer created");
        }
        public void SelectCustomer()
        {
            Console.WriteLine("Customer selected");
        }
    }
}
