using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 9, 95, 3, 89, 37 };
            int i, max, min, n;
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];

                }


            }
            Console.Write("Maximum element= {0}\n", max);
            Console.Write("Minimum element= {0}\n", min);
            Console.ReadLine();
        }
    }
}
