using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //all factor
            Console.WriteLine("Enter Number");
            int n=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
