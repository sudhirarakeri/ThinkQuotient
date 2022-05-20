using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que20
    {
        static void Main(string[] args)
        {
            //Unique Element in array
            int[] arr = { 1, 2, 3, 4, 1, 2, 3, 4, 12, 45, 9, 7 ,8,10};
            int c = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=0;j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        c++;
                }
                if(c==1)
                    Console.WriteLine(arr[i]);
                c = 0;
            }
        }
    }
}
