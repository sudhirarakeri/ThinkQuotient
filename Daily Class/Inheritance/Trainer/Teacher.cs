using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance.Trainer
{
     class Teacher
    {
        string tname,subject;
        int experiance;

        public Teacher()
        {
            Console.WriteLine("in Teacher");
        }

        public Teacher(string tname, string subject, int experiance)
        {
            this.Tname = tname;
            this.Subject = subject;
            this.Experiance = experiance;
        }

        public string Tname { get => tname; set => tname = value; }
        public string Subject { get => subject; set => subject = value; }
        public int Experiance { get => experiance; set => experiance = value; }
    }
}
