using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.StringMethod
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            bool ispalindrome = true;
            Console.WriteLine("Enter a String =");
            string? s = Console.ReadLine();
            int end = s.Length - 1;
            for (int start = 0; start < end; start++, end--)
            {
                if (s[start] != s[end])
                {
                    ispalindrome = false;
                    break;
                }
            }
            if (ispalindrome == true)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
