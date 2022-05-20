using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que7
    {
        static void Main(string[] args)
        {
            //trimorphic number
            Console.WriteLine("Enter number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = 0, n = 0;
            b = a * a*a;
            int m = a;
            while(m>0)
            {
                m = m / 10;
                n++;
            }
            int last = 0, j = 10; ;
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    last = b % j;
                    break;
                }
                j = j * 10;
            }
            Console.WriteLine(b);
            if(a==last)
                Console.WriteLine("Trimorphic Number");
            else
                Console.WriteLine("Not Trimorphic Number");
        }
    }
}
