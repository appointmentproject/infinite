using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class stringchar
    {
        public static void Main()
        {
            String str;
            char ch;
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            Console.Write("Enter the Character:");
            ch = Convert.ToChar(Console.ReadLine());
            int freq = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    freq++;
                }
            }
            Console.WriteLine(freq);
            Console.ReadLine();
        }

    }
}
