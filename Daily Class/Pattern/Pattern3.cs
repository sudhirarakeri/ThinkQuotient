using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Pattern
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            /* 
                5
               45
              345
             2345
            12345
             */
            for (int i = 5; i >= 1; i--)
            {
                for(int space = 1;space <= i-1; space++)
                {
                    Console.Write(" ");
                }
                for (int j =i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
