using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";
           
            Console.WriteLine("enter a string:");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            
                Console.WriteLine("string is palindrome:");
              
            
            else
                Console.WriteLine("string is not a palindrome:");
                Console.ReadLine();
            

        }
    }
}
