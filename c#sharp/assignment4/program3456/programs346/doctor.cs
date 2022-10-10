using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class Doctor
    {
        private int regno;
        private string name;
        private int feecharged;
        public int Regno
        {
            set
            {
                regno = value;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }



        }
        public int Feecharged
        {
            set
            {
                feecharged = value;
            }
        }
        public void GetDetails()
        {
            Console.WriteLine("Regno:" + regno);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Feecharged:" + feecharged);
        }
    }
    class Doctorclass
    {
        public static void Main()
        {
            Doctor d = new Doctor();
            d.Regno = 146;
            d.Name = "Teja";
            d.Feecharged = 300;
            d.GetDetails();
            Console.ReadLine();
        }


    }
}
