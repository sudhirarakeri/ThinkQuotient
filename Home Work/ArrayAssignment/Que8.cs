using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que8
    {
        static void Main(string[] args)
        {
            //even and odd array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];
            int o = 0, e = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }
            }
            for (int i = 0; i < even.Length; i++)
            {
                if (i < e)
                    Console.WriteLine(even[i]);
                else
                    break;
            }
            Console.WriteLine();
            for (int i = 0; i < odd.Length; i++)
            {
                if (i<o)
                    Console.WriteLine(odd[i]);
                else
                    break;
            }
        }
    }
}
