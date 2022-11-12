using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retest
{
    class MulticastDelegates
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1 Called..");

        }
        public static void Method2()
        {
            Console.WriteLine("Method 2 Called..");

        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 Called..");

        }

        public static void Main()
        {
            MulticastDelegates mdel = new MulticastDelegates(Method3);
            mdel += Method1;
            mdel += Method2;
            mdel();  // invoking the delegate, which in turn calls the methods 
            //associated with the delegate object in sequence
            Console.WriteLine("------------------");
            mdel -= Method2; //or mdel= mdel-Method2
            mdel();
            Console.Read();
        }
    }
}
