using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    public class Employee
    {
        int EmployeeID;
        string FirstName;
        string LastName;
        string Title;
        DateTime DOB;
        DateTime DOJ;
        string City;
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>()
                {
                     new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB =Convert.ToDateTime("16/11/1984"), DOJ = Convert.ToDateTime("8/6/2011"),City = "Mumbai" },
                new Employee { EmployeeID =1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB =Convert.ToDateTime("20/08/1984"), DOJ =Convert.ToDateTime("7/7/2012"), City = "Mumbai" },
                new Employee {EmployeeID=1003,FirstName= "Madhavi",LastName= "Oza",Title ="Consultant",DOB=Convert.ToDateTime("14/11/1987"),DOJ=Convert.ToDateTime("12/4/2015"),City= "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB =Convert.ToDateTime ("3/6/1990"), DOJ = Convert.ToDateTime("2/2/2016"), City = "Pune" },
                new Employee {EmployeeID= 1005,FirstName= "Nazia", LastName = "Shaikh",Title="SE",DOB=Convert.ToDateTime("8 / 3 / 1991"),DOJ=Convert.ToDateTime("2/2/2016"),City="Mumbai"},
                new Employee {EmployeeID=1006,FirstName= "Amit",LastName= "Pathak",Title="Consultant",DOB=Convert.ToDateTime("7/11/1989"),DOJ=Convert.ToDateTime("8/8/2014"),City= "Chennai"},
                new Employee {EmployeeID=1007,FirstName="Vijay",LastName= "Natrajan",Title="Consultant",DOB=Convert.ToDateTime("2/12/1989"),DOJ=Convert.ToDateTime("1/6/2015"),City= "Mumbai"},
                new Employee {EmployeeID=1008,FirstName= "Rahul",LastName= "Dubey",Title= "Associate",DOB=Convert.ToDateTime("11/11/1993"),DOJ=Convert.ToDateTime("6/11/2014"),City= "Chennai"},
                new Employee {EmployeeID=1009,FirstName= "Suresh",LastName= "Mistry",Title= "Associate",DOB=Convert.ToDateTime("12/8/1992"),DOJ=Convert.ToDateTime("3/12/2014"),City= "Chennai"},
                new Employee {EmployeeID=1010,FirstName= "Sumit",LastName="Shah",Title="Manager",DOB=Convert.ToDateTime("12 /4/1991"),DOJ=Convert.ToDateTime("2/1/2016"),City= "Pune"},
                 };
                 Display(emplist);
                 Console.ReadLine();
        }
            public static void Display(List<Employee> emplist)
            {
            Console.WriteLine("3a Display detail of all the employee");
            var result = emplist.OrderBy(b => b.EmployeeID).ToList();

            Console.WriteLine("EmployeeID\t FirstName \t LastName\t Title\t DOB\t DOJ\tcity");
            Console.WriteLine("...............................");
            foreach (Employee e in result)
            {
                Console.WriteLine("EmployeeID = {0}, FirstName = {1},LastName = {2}, Title = {3}, DOB = {4} , DOJ= {5} , City = {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);
            }


            Console.WriteLine("3b display details of all the employee whose location is not Mumbai");
            var res2 = from b2 in emplist where b2.City != "Mumbai" select b2;
            Console.WriteLine("EmployeeID\t FirstName\tLastName\tTitle\tDOB\tDOJ\tCity");
            Console.WriteLine("-------------------------------");
            foreach (Employee e in res2)
            {
                Console.WriteLine("EmployeeID = {0}, FirstName = {1},LastName = {2}, Title = {3}, DOB = {4} , DOJ= {5} , City = {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);
            }

           
            Console.WriteLine("3c display details of all the employee whose Title is AsstManager");
            var res3 = from b3 in emplist where b3.Title == "AsstManager" select b3;
            Console.WriteLine("EmployeeID\t FirstName\tLastName\tTitle\tDOB\tDOJ\tCity");
            Console.WriteLine("-------------------------------");
            foreach (Employee e in res3)
            {
                Console.WriteLine("EmployeeID = {0}, FirstName = {1},LastName = {2}, Title = {3}, DOB = {4} , DOJ= {5} , City = {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);
            }
           

            
            Console.WriteLine("3d Display details of all the employee whose Last Name start with S");
             var res4 = from b4 in emplist where b4.LastName[0] == 'S' select b4;
             Console.WriteLine("EmployeeID\t FirstName \tLastName \tTitle \tDOB\t DOJ\t city");
            Console.WriteLine("..................");
            foreach (Employee e in res4)
            {
                Console.WriteLine("EmployeeID = {0}, FirstName = {1},LastName = {2}, Title = {3}, DOB = {4} , DOJ= {5} , City = {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);
            }
            
            Console.WriteLine("3e Display a list of all the employee who have joined before 1/1/2015");
            var val13 = (from a in emplist
                         where a.DOJ < DateTime.Parse("1/1/2015")
                         select a.FirstName);
            foreach (var w in val13)
            {
                Console.WriteLine(w);
            }
           
            Console.WriteLine("3f Display a list of all the employee whose date of birth is after 1/1/1990");
            var val12 = (from a in emplist
                         where a.DOB > DateTime.Parse("1/1/1990")
                         select a.FirstName);
            foreach (var e5 in val12)
            {
                Console.WriteLine(e5);
            }

            
            Console.WriteLine("3g Display a list of all the employee whose designation is Consultant and Associate");
            var val4 = from a in emplist where a.Title == "Consultant" || a.Title == "Associate" select a;
            foreach (var e6 in val4)
            {
                Console.WriteLine(" FirstName = {0}, Title = {1}", e6.FirstName, e6.Title);
            }



            Console.WriteLine("3h Display total number of employees");
            Console.WriteLine($"Total number of Employees: { emplist.Count() }");
            

            Console.WriteLine("-------------------------");
            Console.WriteLine("3i Display total number of employees belonging to “Chennai”");

            var res6 = (from b6 in emplist where b6.City == "Chennai" select b6).Count();
            Console.WriteLine("Total employee belonging to Chennai: " + res6);

           
            
            Console.WriteLine("-------------------------");
            Console.WriteLine("3j Display highest employee id from the list");
            var res7 = (from a in emplist select a.EmployeeID).Max();
            Console.WriteLine(res7);


            Console.WriteLine("-------------------------");
            Console.WriteLine("3k Display total number of employee who have joined after 1/1/2015");
            var val14 = (from a in emplist
                         where a.DOJ > DateTime.Parse("1/1/2015")
                         select a.FirstName);
            foreach (var e7 in val14)
            {
                Console.WriteLine(e7);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("3l Display total number of employee whose designation is not Associate");
            var res8 = (from b7 in emplist where b7.Title != "Associate" select b7.EmployeeID).Count();
            Console.WriteLine("not associate :" + res8);




            Console.WriteLine("-------------------------");
            Console.WriteLine("3m  Display total number of employee based on City ");

            var res9 = (from b8 in emplist
                           group b8.EmployeeID by b8.City into grp
                           select new
                           {
                               city = grp.Key.ToString(),
                               Count = grp.Count()

                           }).ToList();
            foreach (var e8 in res9)
            {
                Console.WriteLine(e8);
            }


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("3n Display total number of employee based on City and Title");

         

            var res10 = emplist.OrderBy(c => c.City).ThenBy(c => c.Title);
            foreach (var e in res10)
            {
                Console.WriteLine("EmployeeID = {0}, FirstName = {1},LastName = {2}, Title = {3}, DOB = {4} , DOJ= {5} , City = {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);
            }

        



            Console.WriteLine("------------------------------------------");
            Console.WriteLine("3o Display total number of employee who is youngest in the list");
            var res11 = (from a in emplist
                           select a.DOB + "" + "name:" + a.FirstName + "" + "  is the youngest employee").Min();
            Console.WriteLine(res11);
            Console.Read();
            }
    }
}



        
    
