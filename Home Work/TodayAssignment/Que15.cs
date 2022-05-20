using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que15
    {
        static void Main(string[] args)
        {
            int[] n1 = {1,2,3,4,5,6,7,8,9,10};
            int[] n2 = {11,12,13,14,15,6,7,8,9,10};
            int[] third=new int[n1.Length];
            int c1 = 0,c2=0;
            for(int i=0,i1=0; i<n1.Length||i1<n2.Length; i++,i1++)
            {
                for(int j=i+1; j< n1.Length-1; j++)
                {
                    if (n1[i] == n1[j])
                        c1++;
                }
                for(int j = i1 + 1;j < n2.Length - 1;j++)
                {
                    if (n2[i] == n2[j])
                        c2++;
                }
            }
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
