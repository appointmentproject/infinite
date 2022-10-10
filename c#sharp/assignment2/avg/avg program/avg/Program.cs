using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            p.array();
            p.maxmin();
            Console.Read();
            }
        //1a
        public void array()
        { 
            int[] arr = { 1, 2, 6, 2, 18};
          
            int i,sum = 0;
            float average = 0.0F;
            for( i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine("Average of array elements:" + average);
            Console.ReadLine();

        }
        public void maxmin()
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
