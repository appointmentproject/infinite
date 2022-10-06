using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4N5
{
    class customer
    {
        int custid, age, phone;
        string custname, city;
        public customer()
        {
            custid = 46;
            custname = "Teja";
            age = 21;
            phone = 876756796;
            city = "Hyd";
        }
        public void Acceptcustomer()
        {
            Console.WriteLine("enter customer details:");
            custid = Convert.ToInt32(Console.ReadLine());
            custname = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            phone = Convert.ToInt32(Console.ReadLine());
            city = Console.ReadLine();

        }
        public void DisplaycustomerDetails()
        {
            Console.WriteLine($"customer Name : {custname}\n " +
                $"customerid :{custid}\n " +
                $"customerAge:{age} \n" +
                $"customerno :{phone}\n" +
                $"customercity :{city}\n");
            Console.ReadLine();
        }
        //destructo
        ~customer()
        {
            Console.WriteLine("bye from customer");
            Console.ReadLine();
        }


        static void Main()
        {
            customer c = new customer();
            c.DisplaycustomerDetails();
            Console.ReadLine();
        }
    }
}

