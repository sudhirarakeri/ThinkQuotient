using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            //print index
            int[] arr = { 23, 45, 76, 89, 12, 50 };

            int a = 89;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == a)
                    Console.WriteLine("Index no. is "+i);
            }
        }
    }
}
