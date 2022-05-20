using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que14
    {
        static void Main(string[] args)
        {
            //reverse array 
            int[] arr = {3, 90, 45, 29, 37, 78};

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1; j<=arr.Length-1; j++)
                {
                    if(arr[i]<arr[j])
                    {
                        int temp=arr[i];
                        arr[i]=arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(int i in arr)
                Console.WriteLine(i);
        }
    }
}
