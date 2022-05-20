using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que17
    {
        static void Main(string[] args)
        {
            //replace 0 to 1
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    arr[i] = 1;
            }
            foreach(int i in arr)
                Console.WriteLine(i);
        }
    }
}
