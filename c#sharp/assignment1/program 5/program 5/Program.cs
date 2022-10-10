using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenhit, celsius ;
            Console.WriteLine("temperature in fahrenhit is:");
           fahrenhit=Convert.ToInt32(Console.ReadLine());
            celsius = (fahrenhit-32) * 5 / 9;
            Console.WriteLine("temperature in celsius:{0}\n", celsius);
            Console.ReadLine();

        }
    }
}
