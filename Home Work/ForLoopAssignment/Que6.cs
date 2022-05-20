using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            //base and power a^b
            Console.WriteLine("enter a base");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a Index");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= b; i++)
            {
                result = result * a;
            }
            Console.WriteLine($"{a}^{b} = " + result);
        }
    }
}
