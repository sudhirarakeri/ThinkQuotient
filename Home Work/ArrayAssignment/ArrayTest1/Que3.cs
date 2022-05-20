using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.ArrayTest1
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            //0 sperate
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int cz = 0,cn=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    cn++;
            }
            int[] numarr=new int[cn];
            int[] sortarr=new int[arr.Length];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    numarr[k] = arr[i];
                    k++;
                }
            }
            k = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (numarr.Length - k != 0)
                    sortarr[i] = numarr[i];
                else
                    break;
                k++;
            }
            for(int i = 0; i < sortarr.Length; i++)
            {
                Console.WriteLine(sortarr[i]);
            }
        }
    }
}
