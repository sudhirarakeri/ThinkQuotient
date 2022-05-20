using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Student
    {
        int Age;
        string Name;
        float Percentage;

        public void SetAge(int Age)
        {
            this.Age = Age;
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetPercentage(float Percentage)
        {
            this.Percentage = Percentage;
        }
        public float GetPercentage()
        {
            return Percentage;
        }
    }
    internal class Que6
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.SetAge(20);
            s.SetName("vinod");
            s.SetPercentage(73.90f);
            int age = s.GetAge();
            string name = s.GetName();
            float per = s.GetPercentage();
            Console.WriteLine($"Student Age is {age}, Name is {name}, Percentage is {per}");
        }
    }
}
