using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que16
    {
        static void Main(string[] args)
        {
            //ascedning order
            int[] arr = { 6, 43, 2, 1, 5, 79, 3 };
            Array.Sort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
}
