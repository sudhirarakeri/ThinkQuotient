using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que14
    {
        static void Main(string[] args)
        {
            //Product of digit
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int pod = 1, k = n;
            while(n>0)
            {
                k = n % 10;
                pod = pod * k;
                n = n / 10;
            }
            Console.WriteLine(pod);
        }
    }
}
