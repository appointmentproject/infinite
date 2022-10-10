using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace same
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            int l1, l2;
            Console.WriteLine("enter string one:");
            str1 = Console.ReadLine();
            Console.WriteLine("enter string two:");
            str2 = Console.ReadLine();
            l1 = str1.Length;
            l2 = str2.Length;
            if (l1 == l2)
                Console.WriteLine("two string are equal");
            else
                Console.WriteLine("two strings are not equal");
            Console.ReadLine();
        }
    }
}
