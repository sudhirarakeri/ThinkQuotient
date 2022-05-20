using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            /* 
             11111
             2222
             333
             44
             5
             */
            for(int i = 1; i <= 5; i++)
            {
                for(int j = i; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }
}
