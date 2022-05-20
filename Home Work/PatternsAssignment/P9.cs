using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class P9
    {
        static void Main(string[] args)
        {
            /* 
             EEEEE
             DDDD
             CCC
             BB
             A
             */
            int k = 5;
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (int j = k; j >= 1; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                k--;
            }
        }
    }
}
