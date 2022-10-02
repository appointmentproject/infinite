using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3p
{
    class Program
    {
        static void Main(string[] args)
        {
            int stid,total,avg,m1,m2,m3,m4,m5;
            string stname, year, sem, branch;
            int []marks=new int marks[5];
            internal student()
            {
                stid = 43;
                stname = rama;
                year = final;
                sem = second;
                branch = cse;

            }
            public void getmarks()
            {
                Console.WriteLine("enter c# marks: ");
                m1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter html marks: ");
                m2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter sql marks: ");
                m3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter java marks: ");
                m4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter dotnet marks: ");
                m5 = Convert.ToInt32(Console.ReadLine());
             }
            total = m1 + m2 + m3 + m4 + m5;
            if (marks < 35)
                Console.WriteLine("pass");
            else
                Console.WriteLine("fail");
            Console.WriteLine("total marks:{0}\n", total);
            Console.ReadLine();
            public void displayresult()
            {
                avg = total / 5;
                if (avg > 50)
                    Console.WriteLine("pass");
                else
                    Console.WriteLine("fail");
                Console.ReadLine();
            }



        }

    }
}
