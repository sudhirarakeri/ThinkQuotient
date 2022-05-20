using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.ForLoop
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number=");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for(int i=1; i<n; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine(fact);
        }
    }
}
