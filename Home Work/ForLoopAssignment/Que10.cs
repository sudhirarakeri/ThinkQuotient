﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que10
    {
        static void Main(string[] args)
        {
            //even no. 121 to 229

            for(int i = 121; i <= 229; i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }
        }
    }
}
