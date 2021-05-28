using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class NumberClass
    {
        protected int number = 10; //we can access this variable inside this class
    }
    class DerivedClass : NumberClass //this is inheritance. DerivedClass derives from the NumberClass class
    {
        void Print()
        {
            Console.WriteLine(number); //we can access it in this class as well because it derives from the NumberClass class
        }
    }
    class Program
    {
        static void Main()
        {
            NumberClass num = new NumberClass();
            Console.WriteLine(num.number); // Error. The number variable is inaccessible due to its protection level. 
                                           // The Program class doesn't derive from the NumberClass
        }
    }
}