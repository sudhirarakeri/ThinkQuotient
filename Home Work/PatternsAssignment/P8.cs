﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class P8
    {
        static void Main(string[] args)
        {
            /* 
             ABCDE
             BCDE
             CDE
             DE
             E
             */
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
