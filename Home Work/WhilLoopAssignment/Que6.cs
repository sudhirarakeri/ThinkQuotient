using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            //amicable number
            Console.WriteLine("Enter two pair number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int a1 = 0, b1 = 0;
            for(int i=2;i<=a/2;i++)
            {
                if (a % i == 0)
                    a1 += i;
            }
            for(int i=2;i<=b/2;i++)
            {
                if (b % i == 0)
                    b1 += i;
            }
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            if(a1==b&&b1==a)
                Console.WriteLine("Amicable numbers");
            else
                Console.WriteLine("not Amicable numbers");
        }
    }
}
