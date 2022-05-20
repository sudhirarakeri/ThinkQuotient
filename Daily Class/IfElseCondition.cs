using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    internal class IfElseCondition
    {
        static void Main(string[] args)
        {
            /*
             If(condition)                      if(condition)
                cw();                               cw();
             else if(condition)                 if(condition)
                cw();                               cw();
             else                               if(condition)
                cw();                               cw();
                 |                                    |
            In this case it's take              in this case it's take more time
            less time.                          bcoz it check every if condition
            bcoz any if or else condition       whether previous one is satisfied
            is satisfied then dierectly         or not.
            stop program.
             */

            //Toggle character
            Console.WriteLine("Enter a charcter = ");
            char c = Convert.ToChar(Console.Read());

            if (c >= 65 && c <= 90)
            {
                c = (char)(c + 32);
                Console.WriteLine(c);
            }
            else if (c >= 97 && c <= 122)
            {
                c = (char)(c - 32);
                Console.WriteLine(c);
            }
        }
    }
}
