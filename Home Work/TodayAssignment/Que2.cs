using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //count odd element
            int[] arr = {1,2,3, 4, 5, 6, 7, 8, 9};
            int c = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2 != 0)
                    c++;
            }
            Console.WriteLine(c);
        }
    }
}
