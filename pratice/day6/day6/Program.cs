using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Dotnet
{
    class Student
    {
        private string RollNo;
        private string Name;
        private string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine("Name of the Student :" + Name);
            Console.WriteLine("No of the Student :" + RollNo);
            Console.WriteLine("Class of the Student :" + Class);

        }
    }
    class Marks : Student
    {
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Marks in Subject {0} {1} ", i + 1, a[i]);
            }
            Console.WriteLine();
        }
    }
    class Results : Marks
    {
        int TotalMarks = 0;
        public void GetResults()
        {
            for (int i = 0; i < a.Length; i++)
            {
                TotalMarks += a[i];
            }
        }
        public void DisplayResults()
        {
            Console.WriteLine("==========Results==========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks =" + TotalMarks);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Results res = new Results();
            res.GetData();
            res.GetMarks();
            res.GetResults();
            res.DisplayResults();
            /*apart from the above, calculate the percentage of marks and 
            /then dipaly the grade as below
            >90 = outstanding
            >80 and <90 = excellent
            >70 and <80 = Very Good
            <70 = Can improve
            */
            Console.Read();
        }
    }
}
