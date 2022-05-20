using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que7
    {
        static void Main(string[] args)
        {
            //occurance of each char element
            string n = "hiamitbro";
            char[] c=n.ToCharArray();
            int cou = 0;
            for(int i=0; i<c.Length; i++)
            {
                for(int j=0;j<c.Length;j++)
                {
                    if (c[i] == c[j] && j < i)
                        break;
                    if (c[i] == c[j])
                        cou++;
                }
                if(cou != 0)
                    Console.WriteLine($"the occureance of {c[i]} is {cou}");
                cou = 0;
            }
            
        }
    }
}
