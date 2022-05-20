using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            //string preserving space positions
            string n = "abc de";
            string[] sn = n.Split(" ");
            string rev = "",rev1="";
            for (int j = n.Length - 1; j >= 0; j--)
            {
                if(n[j]!=' ')
                    rev += n[j];
            }
            int k = 0,l=0;
            for (int i = 0; i < sn.Length; i++)
            {
                for (int j = k; j < rev.Length; j++)
                {
                    if (sn[i].Length == l)
                    {
                        rev1 += " ";
                        l = 0;
                        break;
                    }
                    else
                    {
                        rev1 += rev[j];
                        k++;
                        l++;
                    }
                }
            }
            
            Console.WriteLine(rev1);
        }
    }
}
