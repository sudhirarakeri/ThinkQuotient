using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class CoPrime
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for(int i = 0; i < a && i<=b; i++)
            {
                if(a % i == 0 && b % i == 0)
                    c++;
            }
            if(c==1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }
    }
}
