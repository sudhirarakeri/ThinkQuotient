using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class subarray
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = 0;
            for(int i = 0; i < a.Length; i++)
            {
                int z = 0;
                int on = 0;
                for(int j=1;j<a.Length;j++)
                {
                    if (a[j] == 0)
                        z++;
                    else if (a[j] == 1)
                        on++;
                    if(z==on)
                    {
                        int t = j - i + 1;
                        if (max < t)
                            max = t;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
