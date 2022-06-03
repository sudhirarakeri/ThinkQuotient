using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class StonePaperScissorGame
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Welcome to Stone Paper Scissor");
            int n = 1;
            int comp = 0, use = 0;
            while(n<=10)
            {
                Console.WriteLine($"\nRound No. {n}");
                Console.Write("1 - Stone 2 - Paper 3 - Scissor \n Your Choice : ");
                int? user=int.Parse(Console.ReadLine());
                Console.Write($"Computer Choice : ");
                int computer = r.Next(1, 3);
                Console.WriteLine(computer);
                if (user == 2 && computer == 3)
                    Console.WriteLine($"Scissor Beats Paper Computer get +{++comp} Point");
                else if (user == 1 && computer == 2)
                    Console.WriteLine($"Paper Beats Stone Computer get +{++comp} Point");
                else if (user == 3 && computer == 1)
                    Console.WriteLine($"Stone Beats Scissor Computer get +{++comp} Point");
                else if (user == 3 && computer == 2)
                    Console.WriteLine($"Scissor Beats Paper User get +{++use} Point");
                else if (user == 2 && computer == 1)
                    Console.WriteLine($"Paper Beats Stone User get +{++use} Point");
                else if (user == 1 && computer == 3)
                    Console.WriteLine($"Stone Beats Scissor User get +{++use} Point");
                else if (user == computer)
                {
                    Console.WriteLine("Withdraw");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Keyword");
                    continue;
                }
                n++;
                if(n==11)
                {
                    string res = comp > use ? $"\nComputer Wins the Game \n    Score is {comp}" : $"\nUser Wins the Game \n     Score is {use}";
                    Console.WriteLine(res);
                    Console.WriteLine("\nWanna Play Again 1. Yes 2. No");
                    int choice=int.Parse(Console.ReadLine());
                    if (choice == 1)
                        n = 1; comp = 0; use = 0;
                }
            }
            Console.WriteLine("\nThank You !");
        }
    }
}
