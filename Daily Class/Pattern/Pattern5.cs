using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Pattern
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            /* 
                *
               ***
              *****
             *******
            */
            Console.WriteLine("enter value");
            int r=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=r; i=i+1)
            {
                for (int space = 1; space <= r - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j=1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = r-1; i >=1; i--)
            {
                for(int space = 1; space <= r - i; space++)
                {
                    Console.Write(" ");
                }
                for(int j= 2 * i - 1; j>=1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
