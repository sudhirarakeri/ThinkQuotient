using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    public delegate void mydel();
    class Student
    {
        public event mydel Fail;
        public event mydel Distinction;

        public void AcceptMarks(int mark)
        {
            if (mark < 40)
                Fail();     //call the event or raise event
            else if(mark >= 75)
                Distinction();
            Console.WriteLine($"Your score is : {mark}");
        }
    }
    internal class EventBaseDelegate
    {
        public static void FailMsg() => Console.WriteLine("You are Fail");
        public static void DistinctionMsg() => Console.WriteLine("Congratulation You pass with Distinction !");
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Fail += new mydel(FailMsg);
            s.Distinction += new mydel(DistinctionMsg); //binding event with method
            s.AcceptMarks(84);
        }
    }
}
