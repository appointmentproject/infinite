using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class SingleTonObject
    {
        //private static object of the class
        private static SingleTonObject stobj = new SingleTonObject();
        //private constructor
        private SingleTonObject() { }

        public static SingleTonObject GetSingleTonObject()
        {
            return stobj;
        }

        public void GetMessage()
        {
            Console.WriteLine("Hi You are Working with the SingleTon Object..");
        }

        public void SetMessage(string s)
        {
            Console.WriteLine(s);
        }

    }

    //client 1
    class Program
    {
        static void Main(string[] args)
        {
            //  SingleTonObject sto = new SingleTonObject(); cannote invoke private constructor
            SingleTonObject s = SingleTonObject.GetSingleTonObject();
            s.GetMessage();
            s.SetMessage("hi");
            Console.Read();
        }
    }
}