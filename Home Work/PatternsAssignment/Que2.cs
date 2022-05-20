using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //Pattern A
            for(int r = 1; r <=5; r++)
            {
                for(int c = 1; c <=5; c++)
                {
                    if(r==1||c==1||c==5||r==3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern E
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 1 || r == 5 || r == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern F
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 1 || r == 3)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern H
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if ( c == 1 || c == 5 || r == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern I
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 3 || r == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern N
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || c == 5|| (r == 2 && c == 2)||(r==3&&c==3)||(r==4&&c==4))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern O
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 1 || r == 5||c==5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern P
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 1 || r == 3||(c==5&&r==1)||(c==5&&r==2)||(c==5&&r==3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern T
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 3 )
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern Y
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if ((r == 1&&c==1) || (r == 1 && c == 5) || (r == 2 && c == 2)|| (r == 2 && c == 4)|| (r == 3 && c == 3)|| (r == 4 && c == 3)|| (r == 5 && c == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern Z
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || r == 5||(r==2&&c==4)|| (r == 3 && c == 3)|| (r == 4 && c == 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Pattern K
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c==1||(r==1&&c==5)||(r==2&&c==3)||(r==3&&c==2)||(r==4 && c==3)||(r==5&&c==5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
