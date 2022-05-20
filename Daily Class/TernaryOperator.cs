using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    internal class TernaryOperator
    {
        static void Main(string[] args)
        {
            /*Ternary Operator
              It is short form of if else condition.
            Syntax:
                condition ? statement 1 : statement 2;
                              true          false

            if condition is true then statement 1 o.w. false then statement 2.
             */

            Console.WriteLine("Enter a number :");
            int num=Convert.ToInt32(Console.ReadLine());

            string n = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";
            Console.WriteLine(n);
        }
    }
}
