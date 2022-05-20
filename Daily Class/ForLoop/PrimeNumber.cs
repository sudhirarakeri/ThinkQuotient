using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.ForLoop
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n=Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i==0)
                {
                    count++;
                }
            }
            if(count == 2)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
        }
    }
}
