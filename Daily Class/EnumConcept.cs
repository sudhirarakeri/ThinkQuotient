using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    enum Role
    {
        Developer,Tester, Support //By default value is Developer = 0, Tester = 1, Support = 2
    }
  
    internal class EnumConcept
    {
        string name;
        Role role;
        public string Name { get => name; set => name = value; }
        internal Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"\nName is {name} and Role is {role}";
        }
        static void Main(string[] args)
        {
            int x = 1;
            object ob=Enum.ToObject(typeof(Role), x);
            Console.WriteLine(ob);

            EnumConcept e=new EnumConcept();
            Console.Write("Enter a Name : ");
            string? nam = Console.ReadLine();
            Console.WriteLine("\nEnter Role from following list : ");
            /*foreach(var r in Enum.GetNames<Role>())  //another method to show list
                Console.WriteLine(r);*/
            foreach (var r in Enum.GetNames(typeof(Role)))
                Console.WriteLine(r);

            Console.Write("\nEnter Your Choice : ");
            string? choice=Console.ReadLine();

            e.Name = nam;
            e.Role=Enum.Parse<Role>(choice);
            Console.WriteLine(e);
        }
    }
}
