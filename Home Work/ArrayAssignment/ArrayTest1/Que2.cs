using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.ArrayTest1
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //alternating positive and negative number[2]
            int[] arr = { 1, 2, 3, -4, -1, 4 ,-2};
            int nc = 0,pc=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    nc++;
                else
                    pc++;
            }
            int[] p = new int[pc];
            int[] n = new int[nc];
            int ni = 0, pi = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    n[ni] = arr[i];
                    ni++;
                }
                else
                {
                    p[pi] = arr[i];
                    pi++;
                }
            }
            int[] resort=new int[arr.Length];
            int k = 0;
            for(int i = 0; i < resort.Length; i++)
            {
                if (i < nc&&n[i] < 0)
                {
                    resort[k] = n[i];
                    k++;
                }
                if (p[i] >= 0)
                {
                    resort[k] = p[i];
                    k++;
                }
                if (k == resort.Length)
                    break;
            }
            for(int i=0;i<resort.Length;i++)
            {
                Console.WriteLine(resort[i]);
            }
        }
    }
}
