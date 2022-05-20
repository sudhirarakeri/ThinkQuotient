using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            //sort String on their length.
            string n = "I Love UK Country";
            string[] narr = n.Split(" ");
            string rev = "";
            
            for(int i = 0; i < narr.Length; i++)
            {
                for(int j = i+1; j < narr.Length; j++)
                {
                    if (narr[i].Length > narr[j].Length)
                    {
                        string temp = narr[j];
                        narr[j] = narr[i];
                        narr[i] = temp;
                    }
                }
            }
            for(int i = narr.Length-1; i >= 0; i--)
            {
                rev += narr[i]+" ";
            }
            Console.WriteLine(rev);
        }
    }
}
