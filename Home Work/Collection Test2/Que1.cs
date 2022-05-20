using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.Collection_Test2
{
    class Employee
    {
        string name;
        string designation;
        int salry;

        public Employee(string name, string designation, int salry)
        {
            this.name = name;
            this.designation = designation;
            this.salry = salry;
        }

        public override string ToString()
        {
            return $"Employee name {name} Designation {designation} Salary {salry}";
        }
    }
    internal class Que1
    {
        static void Main(string[] args)
        {
            HashSet<Employee> set = new HashSet<Employee>();
            set.Add(new Employee("pavan", "trainee", 20000));
            set.Add(new Employee("kiran", "senior manager", 50000));
            set.Add(new Employee("ram", "QA", 30000));

            foreach (dynamic e in set)
                Console.WriteLine(e);
        }
    }
}
