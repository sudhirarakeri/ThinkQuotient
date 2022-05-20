using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Containment
{
    class Student
    {
        string name;
        int no,age;
        Batch b1=new Batch();
        Address a1=new Address();

        public Student()
        { }
        public Student(int no,string name,int age)
        {
            this.No = no;
            this.Name = name;   
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int No { get => no; set => no = value; }
        public int Age { get => age; set => age = value; }
        internal Batch B1 { get => b1; set => b1 = value; }
        internal Address A1 { get => a1; set => a1 = value; }
    }
    class Batch
    {
        string batchname,subject;

        public string BatchName { get => batchname; set => batchname = value; } 
        public string Subject { get { return subject; } set {subject = value; } }
    }
    class Address
    {
        string address;

        public string Address1 { get => address; set => address = value; }
    }
    internal class Containment
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.No = 1;
            s.Name = "rr";
            s.Age = 45;
            s.B1.BatchName = "microsoft";
            s.B1.Subject = "c#";
            s.A1.Address1 = "pune";
        }
    }
}
