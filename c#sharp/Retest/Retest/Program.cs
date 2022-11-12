using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retest
{

    delegate int NumberChanger(int x, int y);
    class Calculator
    {
       




        static int x,y ,num;



        public static int Add(int x, int y)
        {
            num=x+y;
            return num;
        }
        public static int sub(int x,int y)
        {
            num =x-y;
            return num;
        }
        public static int mul(int x,int y)
        {
            num =x*y;
            return num;
        }
        public static int div(int x, int y)
        {
            num =x/y;
            return num;
        }



        public static int getNum()
        {
            return num;
        }



        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(Calculator.Add);
            NumberChanger nc2 = new NumberChanger(Calculator.sub);
            NumberChanger nc3 = new NumberChanger(Calculator.mul);
            NumberChanger nc4 = new NumberChanger(Calculator.div);




            nc1(10, 5);
            Console.WriteLine("addition of two numbers is :{0}", Calculator.getNum());
            nc2(20, 10);
            Console.WriteLine("subtraction of two numbers is {0}",Calculator.getNum());
            nc3(10, 2);
            Console.WriteLine("multiplication of two numbers is {0}",Calculator.getNum());
            nc4(20, 5);
            Console.WriteLine("division of two numbers is {0}", Calculator.getNum());
            Console.Read();




        }
    }
}
       

