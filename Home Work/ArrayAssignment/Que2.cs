using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //cal avg
            Console.WriteLine("Enter n th length of array");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter a "+n+" number");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            float avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg+=arr[i];
            }
            Console.WriteLine("Average is "+(avg/n)); 
        }
    }
}
