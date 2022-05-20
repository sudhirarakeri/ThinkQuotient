using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    internal class OperatorsAndPrinting
    {
        static void Main(string[] args)
        {
            /*
             Operators
            1. Arithmatic Operators +,-,*,/
            2. Logical Operators >,<,<=,>=,==,!=

            */

            //Printing in diifferent method.
            int a = 7, b = 6;
            string nm = "run";

            Console.WriteLine("name = "+nm+"a = "+a+"b = "+b);
            Console.WriteLine("name ={2} a={0} b={1}",a,b,nm);
            Console.WriteLine($"name = {nm} a={a} b={b}");
        }
    }
}
