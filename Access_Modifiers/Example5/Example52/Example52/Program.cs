using Example51;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example52
{
    //Second project (ASSEMBLY)
    class Program : NumberClassInFirstProject //Inheritance
    {
        public void Print()
        {
            Console.WriteLine(number); //This is OK as well. The class Program derives from the NumberClassInFirstProject clas.
        }
    }

    class Program1
    {
        static void Main()
        {
            Program program = new Program();
            program.Print();
        }
    }
}