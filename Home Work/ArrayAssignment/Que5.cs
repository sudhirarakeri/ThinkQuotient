﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            //reverse
            int[] arr = { 1,2,3,4,5,6,7,8,9,10 };

            for (int i = arr.Length-1; i >0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
