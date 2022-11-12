using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class ArraysEg
    {
        public void ArrayFunctions()
        {
            int[] arr = new int[5] { 6, 23, 1, 45, 12 };
            Console.WriteLine(arr.Length);
            System.Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine((arr.Rank));
        }
    }
}
