using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example51
{
    //First Project (ASSEMBLY)
    public class NumberClassInFirstProject
    {
        protected internal int number = 10; //we can access this variable inside this class
    }
    class ProgramInFirstProject
    {
        void Print()
        {
            NumberClassInFirstProject num = new NumberClassInFirstProject();
            Console.WriteLine(num.number); // This is OK. Anywhere in this project (assembly) 
                                           // we can access the number variable.
        }
    }
}