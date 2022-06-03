using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public delegate void mydel();
    class Bank
    {
        static long balance;
        public event mydel ZeroBal;
        public event mydel InefficientBal;

        public Bank() => balance = 5000;
        public void Debit(long debitamt)
        {
            if (balance - debitamt == 0)
                ZeroBal();
            else if (debitamt > balance)
                InefficientBal();

            Console.WriteLine($"Your Balance is : {balance -= debitamt}");
        }
        public void Credit(long creditamt) => Console.WriteLine($"\nYour Current Balance is : {balance += creditamt}");
    }
    internal class EventDelegateQue
    {
        public static void ZeroMsg() => Console.WriteLine("Balance is Zero");
        public static void InefficientMsg() => Console.WriteLine("Balance is Insufficient");
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.ZeroBal += new mydel(ZeroMsg);
            b.InefficientBal += new mydel(InefficientMsg);

            b.Debit(5000);
            b.Credit(400);
        }
    }
}
