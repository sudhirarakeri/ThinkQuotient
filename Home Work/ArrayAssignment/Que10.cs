using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que10
    {
        static void Main(string[] args)
        {
            //pair of integer
            int[] arr = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };
            int n = 7;
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]+arr[j]==n)
                        Console.WriteLine("("+arr[i]+","+arr[j]+")");
                }
            }
        }
    }
}
