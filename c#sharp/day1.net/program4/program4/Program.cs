using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            int stid,a,b,c,avg,sum;
            string stname;
            Console.Write("enter stid:");
            stid = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter stname:");
            stname = (Console.ReadLine());
            Console.Write("enter c# marks:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter html marks:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter sql marks:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            sum = a + b + c;
            Console.WriteLine("total marks:{0}.\n", sum);
            Console.ReadLine();
            avg = sum / 3;
            Console.WriteLine("average marks:{0}.\n", avg);
            Console.ReadLine();
            if (avg > 35)
                Console.WriteLine("pass");
            else
                Console.WriteLine("fail");
            Console.ReadLine();

        }
    }
}
