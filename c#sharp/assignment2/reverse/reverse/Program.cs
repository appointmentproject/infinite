using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int i, l;
            Console.Write("enter a string:");
            str = Console.ReadLine();
            l = str.Length -1;
            for(i=l;i>=0;i--)
            {
                str1=str1+str[i];
            }
            Console.WriteLine("reverse string is: {0}\n", str1);
            Console.ReadLine();
        }
    }
}
