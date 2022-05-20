using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            //array iterating
            int[] arr = {1,2,3,4, 5, 6, 7, 8, 9};
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
