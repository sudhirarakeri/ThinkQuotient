using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Employee
    {
        int Id;
        string Name;
        long Salary;

        public void SetId(int Id)
        {
            this.Id = Id;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetSalary(long Salary)
        {
            this.Salary = Salary;
        }
        public long GetSalary()
        {
            return Salary;
        }
    }
    internal class Que5
    {
        static void Main(string[] args)
        {
            Employee e=new Employee();
            e.SetId(208822);
            e.SetName("Ram");
            e.SetSalary(20000);
            int id=e.GetId();
            string name=e.GetName();
            long sal=e.GetSalary();
            Console.WriteLine($"Employee Id is {id}, Name is {name}, Salary is {sal}");
        }
    }
}
