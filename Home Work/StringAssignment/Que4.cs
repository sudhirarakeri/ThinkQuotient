using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que4
    {
        public static string InReseverse(string n)
        {
            string rev = "";
            for(int i = n.Length-1; i >= 0; i--)
            {
                rev += n[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            //print reverse all words except the first and last words
            string n = "Hi how are you students";
            string[] narr = n.Split(" ");
            string reverse = "";
            
            for(int i = 0; i < narr.Length; i++)
            {
                if(i!=0&&i!=narr.Length-1)
                {
                    reverse+=InReseverse(narr[i])+" ";
                }
                else
                    reverse+=narr[i]+" ";
            }
            Console.WriteLine(reverse);
        }
    }
}
