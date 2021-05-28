using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class NumberClass
    {
        public int number = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberClass num = new NumberClass();
            Console.WriteLine(num.number); // Error. We can't access the number variable because 
                                           // it has the private access modifier and its only accessible in the NumberClass class
        }
    }
}