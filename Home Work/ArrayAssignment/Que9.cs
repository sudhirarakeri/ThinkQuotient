using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que9
    {
        static void Main(string[] args)
        {
            //max min
            int[] arr = { 23, 45, 76, 89, 12, 50 };
            int max = 0, min = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(i==0)
                    min = arr[i];
                if(max<arr[i])
                    max = arr[i];
                if(min>arr[i])
                    min = arr[i];
            }
            Console.WriteLine("max is "+max);
            Console.WriteLine("min is "+min);
        }
    }
}
