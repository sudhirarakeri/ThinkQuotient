using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que13
    {
        static void Main(string[] args)
        {
            //no. of digit
            Console.WriteLine("Enter Number");
            long n=Convert.ToInt64(Console.ReadLine());
            int count = 0;
            for(int i=0;i<=n;i++)
            {
                n = n / 10;
                i = 0;
                count++;
            }
            Console.WriteLine("Total No. of digit is "+count);
        }
    }
}
