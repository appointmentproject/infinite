using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Dotnet
{
    class Employee
    {
        //fields / data members
        int Empid;
        string EmpName;
        float Empsal;
        //constructors
        // 1. empty constructor
        internal Employee()
        {
            int myvar = 100;
            Console.WriteLine(myvar);
            Empid = 1;
            EmpName = "Ramakrishna";
            Empsal = 30000.50f;
        }
        //2. parameterized constructors
        public Employee(int eid, string ename, float esal)
        {
            Empid = eid;
            EmpName = ename;
            Empsal = esal;
        }

        //3.
        public Employee(int Empid, string EmpName)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
        }
        //4.
        public Employee(string Ename, int e)
        {
            this.Empid = e;
            this.EmpName = Ename;
        }
        //methods/functions
        public void AcceptEmployee()
        {
            Console.WriteLine("Enter Employee Details:");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            Empsal = Convert.ToSingle(Console.ReadLine());
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine($"Employee Name : {EmpName}, Employeeid :{Empid}, draws a salary of :{Empsal}");
        }
        //destructor
        ~Employee()
        {
            Console.WriteLine("Bye from Employee");
            Console.Read();
        }
    }
    class DriverClass
    {
        static void Main()
        {
            Employee e = new Employee(); //default constructor provided by the framework
            // Console.WriteLine(employee.Empid + " "+employee.EmpName+ " "+employee.Empsal);
            e.DisplayEmpDetails();

            Employee e1 = new Employee(101, "Anushree");
            e1.DisplayEmpDetails();
            Employee e2 = new Employee(200, "Tejaswi", 35000);
            e2.DisplayEmpDetails();
            Employee e3 = new Employee("Varsha", 2);
            e3.DisplayEmpDetails();
            e = null;
            e1 = null; e2 = null; e3 = null;
            GC.Collect();
            //e.DisplayEmpDetails(); //throws nullreference exception
            Console.Read();
        }
    }
}
