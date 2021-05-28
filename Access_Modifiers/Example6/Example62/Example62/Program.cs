using Example61;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example62
{
    //Second project (ASSEMBLY)
    class NumberClassInSecondProject : NumberClassInFirstProject //Inheritance
    {
        new public void Print()
        {
            //Console.WriteLine(number); //KO. Not same assembly.
            base.Print();
        }
    }

    class NumberDerivedClassInSecondProject : NumberDerivedClassInFirstProject //Inheritance
    {
        new public void Print()
        {
            //Console.WriteLine(number); //KO. Not same assembly.
            base.Print();
        }
    }

    class Program1
    {
        static void Main()
        {
            ProgramInFirstProject number0 = new ProgramInFirstProject();
            number0.Print();
            NumberClassInSecondProject number1 = new NumberClassInSecondProject();
            number1.Print();
            NumberDerivedClassInSecondProject number2 = new NumberDerivedClassInSecondProject();
            number2.Print();
        }
    }
}