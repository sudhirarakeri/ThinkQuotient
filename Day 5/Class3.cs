using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 12, 13, 14, 16, 17, 19, 20 };
            Array.Sort(arr);
            int l = arr.Length;
            for(int i = 0; i < arr.Length-1; i++)
            {
                int c = 0;
                if (arr[i] + 1 != arr[i+1])
                {
                    c = arr[i] + 1;
                    Console.WriteLine(c);
                }                                    
            }
            
        }
    }
}
