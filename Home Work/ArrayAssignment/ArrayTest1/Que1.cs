using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.ArrayTest1
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //swap 1st two and last two
            int[] arr = {1,2,3, 4, 5, 6, 7, 8, 9, 10};
            int h = 8;
            for(int i = 0; i < arr.Length; i++)
            {
                if(h<arr.Length)
                {
                    int temp=arr[i];
                    arr[i]=arr[h];
                    arr[h]=temp;
                    h++;
                }
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
