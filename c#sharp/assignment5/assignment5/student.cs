using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    interface IStudent
    {
        string Name { get; set; }
        int StudentId { get; set; }
        void ShowDetails();
    }
    class DayScholar : IStudent
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("Student Id :" + StudentId + " " + ", and Student Name is: " + Name);
        }

    }
    class Resident : IStudent
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("student Id : " + StudentId + " " + " , and Student Name is: " + Name);
        }

    }
    class student
    {
        static void Main(string[] args)
        {
            DayScholar ds = new DayScholar();
            ds.Name = " Teja";
            ds.StudentId = 46;
            Resident rs = new Resident();
            rs.Name = "sweety";
            rs.StudentId = 43;
            ds.ShowDetails();
            rs.ShowDetails();
            //Console.WriteLine("{0} and  {1} whose studentid is {2} and {3} ", ds.Name, rs.Name, ds.StudentId, rs.StudentId);
            Console.ReadLine();



        }
    }
}
