using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCasestudy
{
    class Appclass : Info
    {

        public void scenario1()
        {

            Student s1 = new Student(1, "Teja  ", Convert.ToDateTime("03/03/2000"));
            Student s2 = new Student(2, "Sweety", Convert.ToDateTime("23/05/2001"));

            Info i = new Info();
            Console.WriteLine("student details");

            Console.WriteLine("SId \t SName \t\t DOB");
            Console.WriteLine("========================================");
            i.display(s1);
            i.display(s2);



        }
        public void Scenario1()
        {
            Course c1 = new Course(1, "Java   ", " 4 months", 25000);
            Course c2 = new Course(2, "c sharp", " 3 months", 30000);
            Console.WriteLine("course details");
            Console.WriteLine("CId \t CName \t Cduration\t Cfee");
            Console.WriteLine("=========================================");
            Info i = new Info();
            i.Display(c1);
            i.Display(c2);
        }

        public void scenari02()
        {
            Student[] S = new Student[2];

            S[0] = new Student(2, "RamaKrishna", Convert.ToDateTime("12/09/1997"));

            S[1] = new Student(3, "Chithra    ", Convert.ToDateTime("06/01/1999"));

            Console.WriteLine("student details");
            Console.WriteLine("SId \t SName \t\t DOB");
            Console.WriteLine("=========================================");
            for (int i = 0; i < 2; i++)
            {
                display(S[i]);
            }


        }
        public void Scenari02()
        {
            Course[] C = new Course[2];
            C[0] = new Course(3, "Python", "4 months", 35000);
            C[1] = new Course(4, "SQL", "3 months", 30000);
            Console.WriteLine("course details");
            Console.WriteLine("CId \t CName \t  Cduration\t Cfee");
            Console.WriteLine("===========================================");
            for (int i = 0; i < 2; i++)
            {
                Display(C[i]);
            }
        }



        public void scenari03()
        {
            Console.WriteLine("enter the no.of students");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number - 1; i++)
            {
                Console.WriteLine("enter studentid : ");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter studentname : ");
                string sname = Console.ReadLine();
                Console.WriteLine("enter studentdateofbirth : ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Student[] S = new Student[number];
                S[i] = new Student(sid, sname,dob);
                Console.WriteLine("student details");
                Console.WriteLine("SId \t SName\t DOB");
                Console.WriteLine("----------------------------------");
                display(S[i]);
            }
        }
        public void Scenari03()
        {
            Console.WriteLine("enter the no. of Course");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("enter courseId :");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter courseName :");
                string cname = Console.ReadLine();
                Console.WriteLine("enter courseduration :");
                string cduration = Console.ReadLine();
                Console.WriteLine("enter coursefee :");
                int cfee = Convert.ToInt32(Console.ReadLine());

                Course[] C = new Course[Number];
                C[i] = new Course(cid, cname, cduration, cfee);
                Console.WriteLine("course details");
                Console.WriteLine("CId \t CName \t  Cduration\t Cfee");
                Console.WriteLine("-----------------------------------------------------");
                Display(C[i]);
            }
        }

        static void Main()
        {

            Appclass a = new Appclass();
         //student details...
            //a.scenario1();
            //a.scenari02();
            //a.scenari03();
         //course details...
            //a.Scenario1();
            //a.Scenari02();
            //a.Scenari03();

            Appengine ae = new Appengine();
            //ae.ListOfStudents();
            //ae.ListOfcourses();
            //ae.ListOfEnrollement();

            UserInterface UserInterface = new Appclass();

            //UserInterface.showFirstScreen();
            //UserInterface.showStudentScreen();
            //UserInterface.showAdminScreen();
            //UserInterface.showStudentRegistrationScreen();
            //UserInterface.introduceNewCourseScreen();
            //UserInterface.showAllStudentsScreen();
            //UserInterface.showAllCoursesScreen();





            Console.ReadLine();
        }
    }
}
