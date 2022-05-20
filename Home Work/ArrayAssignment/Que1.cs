using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //Single Dimension and Print
            int[] arr = new int[10];
            Console.WriteLine("Enter a 10 number");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
