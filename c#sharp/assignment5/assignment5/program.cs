using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public int Grade;
        public abstract Boolean IsPassed(int Grade);
    }
    class Undergraduate : Student
    {
        public override bool IsPassed(int Grade)
        {
            if (Grade < 70)
            {
                Console.WriteLine("fail");
                return false;
            }
            else
            {
                Console.WriteLine("pass");
                return true;
            }
        }
    }
    class Graduate : Student
    {
        public override bool IsPassed(int Grade)
        {
            if (Grade < 80)
            {
                Console.WriteLine("fail");
                return false;
            }
            else
            {
                Console.WriteLine("pass");
                return true;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Student stud = new Undergraduate();
            stud.Name = "sweety";
            stud.StudentId = 146;
            Console.WriteLine("enter the grade");
            stud.Grade = Convert.ToInt32(Console.ReadLine());
            stud.IsPassed(stud.Grade);
            stud = new Graduate();
            stud.Name = "teja";
            stud.StudentId = 543;
            Console.WriteLine("enter the grade");
            stud.Grade = Convert.ToInt32(Console.ReadLine());
            stud.IsPassed(stud.Grade);
            Console.Read();
        }



    }
}
