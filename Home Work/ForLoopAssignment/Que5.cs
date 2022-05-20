using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            //common factor using 2 no.
            Console.WriteLine("Enter Two Number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //int n = a<=b?a:b;
            
            for(int i=1;i<=a && i<=b;i++)
            {
                if(a%i==0 && b%i==0)
                    Console.WriteLine(i);
            }
        }
    }
}
