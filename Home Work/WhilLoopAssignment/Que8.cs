using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que8
    {
        static void Main(string[] args)
        {
            //twin prime
            Console.WriteLine("Enter a Two number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int flag1 = 0,flag2=0;
            for(int i=2;i<a/2;i++)
            {
                if(a%i==0)
                {
                    flag1++;
                    break;
                }
            }
            for(int i=1;i<b/2;i++)
            {

                if (b % i == 0)
                {
                    flag2++;
                }
            }
            int t = 0;
            if(flag1==flag2)
            {
                t = a - b;
                if(t==2||t==-2)
                    Console.WriteLine("Twin Prime");
                else
                    Console.WriteLine("Not a Twin Prime");
            }
            else
                Console.WriteLine("Invalid Input bcoz not a prime no. !");
        }
    }
}
