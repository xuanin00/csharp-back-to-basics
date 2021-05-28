using Example41;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example42
{
    //Second project (ASSEMBLY)
    class Program
    {
        static void Main()
        {
            NumberClassInFirstProject num = new NumberClassInFirstProject();
            Console.WriteLine(num.number); // Error. The number variable is inaccessible due to its protection level. 
                                           //The Program class in second project can't access the internal members from another project
        }
    }
}