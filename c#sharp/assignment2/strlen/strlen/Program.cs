using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strlen
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            Console.Write("enter a string:");
            str = Console.ReadLine();
            foreach(char chr in str)
                {
                l += 1;
            }
            Console.Write("Length of the string is :{0}\n\n", l);
            Console.ReadLine();
        }
    }
}
