using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static sqlEntities2 db = new sqlEntities2();
        static Product1 prod = new Product1();
        static void Main(string[] args)
        {
            Console.WriteLine("1. Insert into Products :");
            Console.WriteLine("2. Display Products:");
            Console.WriteLine("3. Exit :");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Enter ProductId :");
                prod.ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                prod.ProdName = Console.ReadLine();
                Console.WriteLine("Enter Price :");
                prod.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Quantity on Hand :");
                prod.QtyAvailable = Convert.ToInt32(Console.ReadLine());
                db.Product.Add(prod);
                db.SaveChanges();
                Console.WriteLine("Succesfully added a product..");
            }
            else if (choice == "2")
            {
                var prd = from p in db.Product
                          select p;

                foreach (var item in prd)
                {
                    Console.WriteLine(item.ProductId + " " + item.ProdName + " " + item.Price + " " + item.QtyAvailable);
                }
            }
            else

                Console.WriteLine("thanks..");

            Sp_call();
            Console.Read();
        }

        static void Sp_call()
        {
            var elist = db.FewEmployee();
            foreach (var item in elist)
            {
                Console.WriteLine(item.Empid);
                Console.WriteLine(item.Empname);
                Console.WriteLine(item.Salary);
            }

        }
    }
}
