using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class P1
    {
        static void Main(string[] args)
        {
            /* 
             12345
             2345
             345
             45
             5
             */
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
