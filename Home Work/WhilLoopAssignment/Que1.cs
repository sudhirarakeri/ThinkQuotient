using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //spy no.
            Console.WriteLine("Enter a Number");
            int n=Convert.ToInt32(Console.ReadLine());
            int sod = 0, pod = 1, rev = 0;
            while(n>0)
            {
                rev = n % 10;
                sod += rev;
                pod = pod * rev;
                n = n / 10;
            }
            if(sod==pod)
                Console.WriteLine("Spy Number");
            else
                Console.WriteLine("No Spy Number");
        }
    }
}
