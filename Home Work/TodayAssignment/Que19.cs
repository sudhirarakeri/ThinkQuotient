using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que19
    {
        static void Main(string[] args)
        {
            //smallest char
            char[] arr = { 'A', 'D', 'E', 'x', 'z', 'R' };
            char min=arr[0];

            for(int i = 0; i < arr.Length-1; i++)
            {
                if(min >arr[i])
                    min=arr[i];
            }
            Console.WriteLine(min);


            Array.Sort(arr);
            Console.WriteLine(arr[0]);
        }
    }
}
