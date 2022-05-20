using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            //factorial
            Console.WriteLine("Enter a number=");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i < n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
