using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que8
    {
        static void Main(string[] args)
        {
            //count duplicate char
            string n = "ramayana";
            int c = 0;
            for(int i=0;i<n.Length;i++)
            {
                for(int j=0;j<n.Length;j++)
                {
                    if (n[i] == n[j] && j < i)
                        break;
                    else if (n[i] == n[j])
                        c++;
                }
                if(c>1)
                    Console.WriteLine($"Total no. of {n[i]} is {c}");
                c = 0;
            }
        }
    }
}
