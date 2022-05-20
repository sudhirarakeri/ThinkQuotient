using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class P2
    {
        static void Main(string[] args)
        {
            /* 
             55555
             4444
             333
             22
             1
             */
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
