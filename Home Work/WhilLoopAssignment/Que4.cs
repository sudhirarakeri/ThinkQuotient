using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            //harshad number
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            int m = n,add=0,k=0;
            while(m>0)
            {
                k = m % 10;
                add += k;
                m = m / 10;
            }
            if(n%add==0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not a Harshad Number");

        }
    }
}
