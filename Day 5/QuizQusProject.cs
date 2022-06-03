using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day_5
{
    internal class QuizQusProject
    {
        public static void CSharp()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("1. Value type variables in C# are derived from the class System.ValueType ? \n A. True \n B. False ", "A");
            d.Add("2. Which of the following converts a type to a double type in C# ? \n A. ToDecimal \n B. ToDouble \n C. ToInt16 \n D. ToInt32", "B");
            d.Add("3. Which of the following operator creates a pointer to a variable in C# ? \n A. sizeof \n B. typeof \n C. & \n D. *", "D");
            d.Add("4. Which of the following method helps in returning more than one value ? \n A. Value parameters \n B. Reference parameters \n C. Output parameters \n D. None of the above", "C");
            d.Add("5. Which of the following property of Array class in C# checks whether the Array has a fixed size ? \n A. IsFixedSize \n B. IsStatic \n C. Length \n D. None of the above.", "A");
            d.Add("6. Operator overloading is a kind of dynamic polymorphism \n A. True \n B. False ", "B");
            d.Add("7. Which of the following preprocessor directive allows you to undefine a symbol in C# ? \n A. define \n B. undef \n C. region \n D. endregion", "B");
            d.Add("8. CLR is the .Net equivalent of ____ \n A. Java Virtual machine \n B. Common Language Runtime \n C. Common Type System \n D. Common Language Specification", "A");
            d.Add("9. Abstract class contains ____ \n A. Abstract methods \n B. Non Abstract methods \n C. Both \n D. None", "C");
            d.Add("10. The default scope for the members of an interface is ____ \n A. private \n B. public \n C. protected \n D. internal", "B");

            int c = 0;
            foreach (KeyValuePair<string, string> k in d)
            {
                Console.WriteLine();
                Console.WriteLine(k.Key);
                Console.Write("Choose Your Option : ");
                string? choice = Console.ReadLine();
                if (choice.ToUpper() == k.Value)
                    c++;
            }
            Console.WriteLine();
            if (c > 4)
                Console.WriteLine($"|| Congratulation You Successfully Clear the Exam ||\n           Your Score is {c}");
            else
                Console.WriteLine($"You not Clear the Exam Try Again !\n Your Score is {c}");
            Console.WriteLine();
            Console.Write("1. Check Answer or 2. Exit \n  Enter Choice : ");
            string? ch = Console.ReadLine();
            if (ch == "1")
            {
                foreach (KeyValuePair<string, string> k in d)
                {
                    Console.WriteLine();
                    Console.WriteLine(k.Key + "\n Ans. " + k.Value);
                }
            }
        }
        public static void Java()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("1. Number of primitive data types in Java are ? \n A. 6 \n B. 7 \n C. 8 \n D. 9", "C");
            d.Add("2. What is the size of float and double in java ? \n A. 32 & 64 \n B. 32 & 32 \n C. 64 & 64 \n D. 64 & 32", "A");
            d.Add("3. Automatic type conversion is possible in which of the possible cases ? \n A. Byte to Int \n B. Int to Long \n C. Long to Int \n D. Short to Int", "B");
            d.Add("4. Select the valid statement ? \n A. char[] ch = new char(5) \n B. char[] ch = new char[5] \n C. char[] ch = new char() \n D. char[] ch = new char[]", "B");
            d.Add("5. Arrays in java are - \n A. Object Reference \n B. Objects \n C. Primative Data Type \n D. None", "B");
            d.Add("6. compareTo() returns \n A. True \n B. False \n C. An int Value \n D. None", "C");
            d.Add("7. To which of the following does the class string belong to. \n A. java.lang \n B. java.awt \n C. java.applet \n D. java.string", "A");
            d.Add("8. Identify the return type of a method that does not return any value. \n A. int \n B. void \n C. double \n D. None", "B");
            d.Add("9. Where does the system stores parameters and local variables whenever a method is invoked ? \n A. Heap \n B. Stack \n C. Array \n D. Tree", "B");
            d.Add("10. What is the variables declared in a class for the use of all methods of the class called ? \n A. Object \n B. Instance Variable \n C. Reference Variable \n D. None", "B");

            int c = 0;
            foreach(KeyValuePair<string,string> k in d)
            {
                Console.WriteLine();
                Console.WriteLine(k.Key);
                Console.Write("Choose Your Option : ");
                string? choice = Console.ReadLine();
                if (choice.ToUpper() == k.Value)
                    c++;
            }
            Console.WriteLine();
            if(c>4)
                Console.WriteLine($"|| Congratulation You Successfully Clear the Exam ||\n           Your Score is {c}");
            else
                Console.WriteLine($"You not Clear the Exam Try Again !\n Your Score is {c}");
            Console.WriteLine();
            Console.Write("1. Check Answer or 2. Exit \n  Enter Choice : ");
            string? ch = Console.ReadLine();
            if(ch=="1")
            {
                foreach(KeyValuePair<string,string> k in d)
                {
                    Console.WriteLine();
                    Console.WriteLine(k.Key+"\n Ans. "+k.Value);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("User Login \nEnter Your Name : ");
            string? name = Console.ReadLine();
            Console.WriteLine();
            int n = 1;
            do
            {
                Console.WriteLine($"Welcome {name} for playing Quiz: \n 1 - Java \n 2 - C# \n 3 - Quit");
                Console.Write("Enter Your Choice : ");
                string? choice = Console.ReadLine();
                if (choice == "3")
                    break;
                else if(choice == "1")
                {
                    Java();
                    Console.WriteLine();
                    Console.Write("1. Start again or 2. Quit \n Enter Your Choice : ");
                    string? ch= Console.ReadLine();
                    Console.WriteLine();
                    if (ch == "2")
                        n=0;
                }
                else if (choice == "2")
                {
                    CSharp();
                    Console.WriteLine();
                    Console.Write("1. Start again or 2. Quit \n Enter Your Choice : ");
                    string? ch = Console.ReadLine();
                    Console.WriteLine();
                    if (ch == "2")
                        n = 0;
                }
                else
                    Console.WriteLine("Invalid input\n");
            } while (n > 0);
            Console.WriteLine();
            Console.WriteLine("Thank You "+name+"\n  Visit Again!");
        }
    }
}
