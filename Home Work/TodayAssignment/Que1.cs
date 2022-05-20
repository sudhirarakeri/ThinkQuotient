using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //Minmum element from array
            int[] arr = {5,1,2,6,7,8};
            int min=arr[0];

            for(int i=1; i<arr.Length; i++)
            {
                if(min>arr[i])
                    min=arr[i];
            }
            Console.WriteLine(min);
        }
    }
}
