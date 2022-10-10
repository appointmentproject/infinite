using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        public int AccountNum;
        public string CustomerName;
        string AccType;
        char TransactionType;
        float amount;
        float balance;


        public static void Main(string[] args)
        {
            Program p1 = new Program(0146, "Savings", "dhakshayanip");
            p1.amount = 0.1f;
            p1.balance = 30000.00f;
            p1.ShowData();
            Console.WriteLine("Enter transaction type 'D' for Deposit and 'W' for Withdrawl ");
            p1.TransactionType = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Amount");
            p1.amount = Convert.ToSingle(Console.ReadLine());
            p1.balance = p1.Ttype(p1.amount, p1.TransactionType);
            Console.WriteLine("After Transaction");
            Console.ReadLine();
            p1.ShowData();
            
        }
        public Program(int num, string actype, string nme)
        {
            AccountNum = num;
            AccType = actype;
            CustomerName = nme;
        }
        public float Ttype(float amount, char Type)
        {
            if ('d' == Type)
            {
                return Credit(amount);
            }
            else if ('w' == Type)
            {
                return Debit(amount);
            }
            else
            {
                return 0;
            }
        }
        public float Credit(float deposit)
        {
            balance = balance + deposit;
            return balance;
        }
        public float Debit(float Withdrawl)
        {
            balance = balance - Withdrawl;
            return balance;
        }

        public void ShowData()
        {
            Console.WriteLine(" Account Details");
            Console.WriteLine("Account Number: " + AccountNum);
            Console.WriteLine("Account Type: " + AccType);
            Console.WriteLine("Balance: " + balance);
            Console.ReadLine();

        }
    }
        
        
    
}
