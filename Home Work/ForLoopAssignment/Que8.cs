using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que8
    {
        static void Main(string[] args)
        {
            // 2 5 10 17 26 37 50
            Console.WriteLine("Enter Number");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i < n; i++)
            {
                Console.WriteLine(i*i+1);
            }
        }
    }
}
