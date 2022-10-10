using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace day7
{
    class scholarship
    {

        float discount;



        public float Merit()
        {
            int m;
            float f;
            Console.WriteLine("Enter the m");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the f");
            f = int.Parse(Console.ReadLine());



            if (m > 70 && m <= 80)
            {
                discount = (m * 20) / f;
                f = m - discount;
                Console.WriteLine(f);
                Console.ReadLine();

            }
            else



                if (m > 80 && m <= 90)
            {
                discount = (m * 30) / f;
                f = m - discount;
                Console.WriteLine(f);
                Console.ReadLine();
            }



            else



                if (m > 90)
            {
                discount = (m * 50) / f;
                f = m - discount;
                Console.WriteLine(f);
                Console.ReadLine();
            }
            return discount;

        }
        static void Main()
        {
            scholarship p = new scholarship();
            p.Merit();

        }
    }





}

