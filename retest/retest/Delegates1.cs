
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retest
{
    public delegate void GreetingsDelegate(string str); //decl delegate with a signature
    class Delegates1
    {
        public void Show(string s)
        {
            Console.WriteLine("Hello " + s);
        }

        public static void Display(string s)
        {
            Console.WriteLine(s);
        }

        public string Message(string s)
        {
            return s;
        }

        static void Main()
        {
            //assigning a method to a delegate object
            GreetingsDelegate gd = new GreetingsDelegate(Display);
            gd("Hi ! Welcome to Delegates of C#");
            //or
           // gd.Invoke("Hi ! Welcome to Delegates of C#");
            Delegates1 d = new Delegates1();
            d.Show("Direct Call..");
            Display("hello");
            gd = new GreetingsDelegate(d.Show);
            gd("Hi Show Method..");
            Console.Read();
        }
    }
}
