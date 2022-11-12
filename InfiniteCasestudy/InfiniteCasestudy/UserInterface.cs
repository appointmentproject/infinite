using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCasestudy
{
    public abstract class UserInterface
    {

        public void showFirstScreen()
        {
            try
            {

                Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("error");
            }
        }
        public void showStudentScreen()
        {
            try
            {
                Console.WriteLine("welcome to student screen");
                Console.WriteLine("1.student registration\n 2.showFirstScreen");
                Console.WriteLine("Enter your choice ( 1 or 2  ) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showStudentRegistrationScreen();
                        break;
                    case 2:
                        showFirstScreen();
                        break;
                }

            }
            catch (Exception A)
            {
                Console.WriteLine("error");
            }

        }
        public void showAdminScreen()
        {
            try
            {
                Console.WriteLine("welcome to adminscreen");
                Console.WriteLine("1.studentlist\n 2.courselist 3.introducenewcourse 4.showFirstScreen");
                Console.WriteLine("Enter your choice ( 1 or 2 or 3 or 4 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        break;
                    case 2:
                        showAllCoursesScreen();
                        break;
                    case 3:
                        introduceNewCourseScreen();
                        break;
                    case 4:
                        showFirstScreen();
                        break;
                }
            }
            catch (Exception B)
            {
                Console.WriteLine("error");
            }

        }
        public void showAllStudentsScreen()
        {
            Appengine a = new Appengine();
            a.ListOfStudents();
        }
        public void showStudentRegistrationScreen()
        {
            Appclass a = new Appclass();
            a.scenari03();
        }
        public void introduceNewCourseScreen()
        {
            Appclass e = new Appclass();
            e.Scenari03();
        }
        public void showAllCoursesScreen()
        {
            Appengine a = new Appengine();
            a.ListOfcourses();

        }
    }

}
