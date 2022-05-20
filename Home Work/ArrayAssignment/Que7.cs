using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que7
    {
        static void Main(string[] args)
        {
            //count -ve no.
            int[] arr = { -1, -2, -3, 4, 5, 6, 7, 8, 9, 10 };
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                    c++;
                }
            }
            Console.WriteLine("Total no. Of Negative element is "+c);
        }
    }
}
