using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            //remove Characters from the first String which are present in the second String
            string n = "india is great nation";
            string r = "in";
            char[] c=r.ToCharArray();
            string new1 = "";
            int cou = 0;
            for(int i = 0; i < n.Length; i++)
            {
                for(int j=0;j<c.Length;j++)
                {
                    if (c[j] == n[i])
                        cou++;                        
                }
                if(cou == 0)
                    new1 += n[i];
                cou = 0;
            }
            Console.WriteLine(new1);
        }
    }
}
