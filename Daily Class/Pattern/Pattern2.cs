using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Pattern
{
    internal class Pattern2
    {
        static void Main(string[] args)
        {
            /*
              ****
              ***
              **
              *
            for(int r=1;r<=7;r++)
            {
                for(int c=7;c>=r;c--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /*
             1
             12
             123
             1234

            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }*/

            /*
             1
             22
             333 
             444

            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }*/
            
            /*
             5
             54
             543
             5432
             54321
            for (int r = 5; r >=1; r--)
            {
                for (int c = 5; c >= r; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            5
            45
            345
            2345
            12345
            for (int r = 5; r >= 1; r--)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            ABCDE
            BCDE
            CDE
            DE
            E
            for (char r = 'A'; r <= 'E'; r++)
            {
                for (char c = r; c <= 'E'; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            EDCBA
            DCBA
            CBA
            BA
            A
            for (char r = 'E'; r >= 'A'; r--)
            {
                for (char c = r; c >= 'A'; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }*/
        }
    }
}
