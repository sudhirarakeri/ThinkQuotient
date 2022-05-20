using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que12
    {
        static void Main(string[] args)
        {
            //sum of Even number
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int add = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    add = add + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(add);
        }
    }
}
