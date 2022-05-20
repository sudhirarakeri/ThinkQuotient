using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Array
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 3, 4, 5, 77, 88, 99, 100 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length+b.Length];
            int k = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i < a.Length)
                {
                    c[k] = a[i];
                    k++;
                }
                if(i<b.Length)
                {
                    c[k] = b[i];
                    k++;
                }
                if(k==c.Length)
                    break;
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

            /*int aa = 0, bb = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (aa < a.Length&&i%2==0)
                {
                    c[i] = a[aa];
                    aa++;
                }
                else if (bb < b.Length)
                {
                    c[i] = b[bb];
                    bb++;
                }
                else
                {
                    c[i] = a[aa];
                    aa++;
                }
            }*/

            /*for(int i = 0; i < c.Length; i++)
            {
                if (aa < a.Length)
                {
                    c[i] = a[aa];
                    aa++;
                }
                else if (bb < b.Length)
                {
                    c[i] = b[bb];
                    bb++;
                }
            }*/
        }
    }
}
