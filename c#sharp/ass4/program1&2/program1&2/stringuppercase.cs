using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace day4dotnet
{



    class stringuppercase
    {
        public void Display()
        {
            String FirstName, LastName;
            String str1, str2;
            Console.Write("Enter FirstName : ");
            FirstName = Console.ReadLine();
            Console.Write("Enter LastName : ");
            LastName = Console.ReadLine();
            str1 = FirstName.ToUpper();
            str2 = LastName.ToUpper();
            Console.WriteLine("Converted string is: " + str1);
            Console.WriteLine("Converted string is: " + str2);
            Console.Read();
        }



        public static void Main(string[] args)
        {
            stringuppercase p = new stringuppercase();
            p.Display();



        }
    }



}
