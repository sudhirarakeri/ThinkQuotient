using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que17
    {
        static void Main(string[] args)
        {
            //krishnamurthy or not

            Console.WriteLine("Enter Number");
            int a=Convert.ToInt32(Console.ReadLine());
            int n = 1, result = 0 ,m=a;
            int fact = 1;
            for(int i = 0; i <= m; i++)
            {
                n = m % 10;
                m = m / 10;
                for (int j = 1; j <= n; j++)
                {
                    fact = fact * j;
                }
                result = result + fact;
                fact = 1;
                i = 0;
            }
            Console.WriteLine("Sum of Factors Of digit = " + result);
            Console.WriteLine();
            if(result == a)
                Console.WriteLine("Krishnamurthy");
            else
                Console.WriteLine("Not a Krishnamurthy");
        }
    }
}
