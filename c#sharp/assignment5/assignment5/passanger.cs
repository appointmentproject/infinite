using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class PassangerException : ApplicationException
    {
        public string Name;
        public int Age;
        public PassangerException(string msg) : base(msg)
        {
            Console.WriteLine("Enter the name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the age : ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void TicketBooking()
        {
            int tickets;
            Console.WriteLine("enter the num of tickets");
            tickets = Convert.ToInt32(Console.ReadLine());
            if (tickets > 2)
            {
                Console.WriteLine("can't book more than 2 tickets.");
            }
            else
                Console.WriteLine("tickets booked successfully");
        }
        class passanger
        {
            static void Main(string[] args)
            {
                PassangerException pass = new PassangerException("message");
                try
                {
                    pass.TicketBooking();
                }
                catch (PassangerException p)
                {
                    Console.WriteLine(p.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
