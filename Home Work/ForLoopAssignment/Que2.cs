using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //number of table
            Console.WriteLine("Enter Number");
            int n=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"{n} X {i} = "+(n*i));
            }
        }
    }
}
