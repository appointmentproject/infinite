using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10
{
    class Program<T>
    {
        public void Display<T>(string msg, T Val)
        {
            Console.WriteLine("{0} :{1}", msg, Val);
        }


    }
}