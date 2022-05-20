using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class P6
    {
        static void Main(string[] args)
        {
            /* 
             AAAAA
             BBBB
             CCC
             DD
             E
             */
            int k = 5;
            for (char i = 'A'; i <= 'E'; i++)
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
