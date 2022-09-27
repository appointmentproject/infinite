using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            char operation;
            Console.Write("Input first number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation:");
            operation=Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number:");
            b=Convert.ToInt32(Console.ReadLine());
            if(operation=='+')
                Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            else if(operation=='-')
                Console.WriteLine("{0}-{1}={2}",a,b,a-b);
            else if(operation=='*')
                Console.WriteLine("{0}*{1}={2}",a,b,a*b);
            else if(operation=='/')
                Console.WriteLine("{0}/{1}={2}",a,b,a/b);
            else
                Console.WriteLine("invalid character");
            Console.ReadLine();
        }
    }
}
