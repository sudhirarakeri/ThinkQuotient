using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Question
    {// 12345  = 4*3*2*1  + 2! = 24 + 2 =26
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number =");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0,rem=0,fact=1,total=0;
            while(n > 0)
            {
                c++;
                if (c == 1||c%2!=0)
                    n = n / 10;
                else if (c % 2 == 0)
                {
                    rem = n % 10;
                    for (int i = 1; i <= rem; i++)
                    {
                        fact = fact * i;
                    }
                    Console.Write(fact+" ");
                    total = total + fact;
                    n = n / 10;
                    fact = 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum Of Alternative Factorial = "+total);
        }
    }
}
