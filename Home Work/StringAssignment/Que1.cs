using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que1
    {
        public string IsPalindrome(string n)
        {
            string rev = "";
            for(int i = n.Length-1; i >=0; i--)
            {
                rev += n[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            //longest palindrome 
            string n = "mom dad and racecar nayan mim";
            string[] narr = n.Split(" ");
            int l = 0;
            Que1 q=new Que1();
            string longest = "";
            for(int i = 0; i < narr.Length; i++)
            {
                if(q.IsPalindrome(narr[i])==narr[i])
                {
                    if (l < narr[i].Length)
                    {
                        l= narr[i].Length;
                        longest = narr[i];
                    }
                }
            }
            Console.WriteLine(longest);
        }
    }
}
