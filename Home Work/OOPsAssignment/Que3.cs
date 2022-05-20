using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Account
    {
        long Account_No;
        string Account_Name,Branch,Bank_Name;
        int Balance=70000;
        public void Insert()
        {
            Console.WriteLine("Enter Bank Name =");
            Bank_Name =Console.ReadLine();
            Console.WriteLine("Enter Branch =");
            Branch = Console.ReadLine();
            Console.WriteLine("Enter Account Name =");
            Account_Name = Console.ReadLine();
            Console.WriteLine("Enter Account Id =");
            Account_No=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
        }
        public void Display()
        {
            Console.WriteLine("Bank Name ="+Bank_Name);
            Console.WriteLine("Branch ="+Branch);
            Console.WriteLine("Account Name ="+Account_Name);
            Console.WriteLine("Account Id ="+Account_No);
            Console.WriteLine("Balance ="+Balance);
            Console.WriteLine();
        }
        public void Withdraw()
        {
            Console.WriteLine("Plz enter your Withdraw amount ");
            int withdraw=Convert.ToInt32(Console.ReadLine());
            if(withdraw<=Balance)
                Balance = Balance - withdraw;
            else
                Console.WriteLine("Insufficent Balance..");
            Console.WriteLine();
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is {Balance}");
            Console.WriteLine();
        }
    }
    internal class Que3
    {
        static void Main(string[] args)
        {
            Account a=new Account();
            a.Insert();
            a.Display();
            a.Withdraw();
            a.CheckBalance();
            Console.WriteLine("Thank You !");
        }
    }
}
