using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Class1
    {
        static void Main(string[] args)
        {   //arr= 4 5 6 1 2 3
            int[] arr = { 1, 2, 3, 4, 5, 6};
            int h = arr.Length/2,c=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (h < arr.Length)
                {
                    c = arr[i];
                    arr[i] = arr[h];
                    arr[h] = c;
                    h++;
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
