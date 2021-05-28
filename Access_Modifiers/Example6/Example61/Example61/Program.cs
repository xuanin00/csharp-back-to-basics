using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example61
{
    //First Project (ASSEMBLY)
    public class NumberClassInFirstProject
    {
        private protected int number = 10; //we can access this variable inside this class or in derived classes, but only in same assembly
        public void Print()
        {
            Console.WriteLine(number);
        }
    }

    public class NumberDerivedClassInFirstProject : NumberClassInFirstProject
    {
        new public void Print()
        {
            Console.WriteLine(number);
        }
    }

    public class ProgramInFirstProject
    {
        public void Print()
        {
            NumberClassInFirstProject num = new NumberClassInFirstProject();
            num.Print();
            NumberDerivedClassInFirstProject num1 = new NumberDerivedClassInFirstProject();
            num1.Print();
        }
    }
}