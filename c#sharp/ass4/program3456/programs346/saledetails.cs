using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{
    
    
        class saledetails
        {
            //data member
            int SalesNo;
            int ProductionNo;
            int Prize;
            int DateOfSale;
            int Qty;
            public int TotalAmount;



            //Method
            public void sales()
            {
                int Qty, Prize;
                Console.WriteLine("Enter the Qty");
                Qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Prize");
                Prize = int.Parse(Console.ReadLine());
                TotalAmount = Qty * Prize;

            }



            //constructor
            public saledetails(int SalesNo, int ProductionNo, int Qty, int DateOfSale, int Prize)
            {
                this.SalesNo = SalesNo;
                this.ProductionNo = ProductionNo;
                this.Prize = Prize;
                this.Qty = Qty;
                this.DateOfSale = DateOfSale;



            }
            public void Displaysalesdetails()
            {
                Console.WriteLine($"Qty : {Qty}\nsalesNo : {SalesNo}\nProductionNo : {ProductionNo}\nPrize : {Prize}\nDateOfSale : {DateOfSale}\nTotalAmount : {Qty * Prize}");
                Console.Read();
            }
            static void Main()
            {
                saledetails s = new saledetails(10, 130, 7, 6, 20);
                s.Displaysalesdetails();



            }


        }
 }
