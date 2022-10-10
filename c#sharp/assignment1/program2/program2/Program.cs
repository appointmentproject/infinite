using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input an number:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
                Console.WriteLine("{0} is a positive number.\n", n);
            else
                Console.WriteLine("{0} ia a negative number.\n", n);
            Console.ReadLine();

        }
    }
}
