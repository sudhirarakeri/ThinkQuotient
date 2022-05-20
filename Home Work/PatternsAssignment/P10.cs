using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class P10
    {
        static void Main(string[] args)
        {
            /* 
             EDCBA
             EDCB
             EDC
             ED
             E
             */
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
