using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCasestudy
{
    public class Appengine : Info
    {
        public void introduce(Course course)
        {
            Course[] C = new Course[1];
            C[0] = new Course(3, "DOTnet", " 5 months", 40000);
            Info i = new Info();
            //Console.WriteLine("course details");
            //Console.WriteLine("c_Id \t Name \t  duration\tfee");
            //Console.WriteLine("------------------------------------------");
            i.Display(C[0]);
        }
        public void register(Student student)
        {

            Student[] S = new Student[1];
            S[0] = new Student(3, "Dhakshayani", Convert.ToDateTime("27/12/2000"));
            Info i = new Info();
            //Console.WriteLine("student details");
            //Console.WriteLine("Std_Id \t Name \t\t   DOB");
            //Console.WriteLine("----------------------------------");
            i.display(S[0]);
        }
        public Student[] ListOfStudents()
        {
            Console.WriteLine("list of students");
            Student[] S = new Student[1];

            Appengine ae = new Appengine();
            ae.register(S[0]);
            Appclass a = new Appclass();
            a.scenario1();
            a.scenari02();
            a.scenari03();
            return S;


        }

        public Course[] ListOfcourses()
        {
            Console.WriteLine("list of Course");
            Course[] C = new Course[1];
            Appengine ae = new Appengine();
            ae.introduce(C[0]);
            Appclass a = new Appclass();
            a.scenario1();
            a.scenari02();
            a.scenari03();

            return C;
        }
        //public void enroll(Student student,Course course)//,LocalDate localDate)
        //{


        //    Appengine a = new Appengine();
        //    a.ListOfStudents();
        //    a.ListOfcourses();
        //    IEnumerable<string> stu = (IEnumerable<string>)student.name;
        //    //Info I = new Info();
        //    //I.display(a.ListOfStudent());


        //}
        //public Enroll[] ListOfEnrollement()
        //{
        //    Enroll[] e = new Enroll[1];



        //    Appengine a = new Appengine();
        //    a.enroll();

        //    Student[] S = a.ListOfStudents();
        //    Course[] C = a.ListOfcourses();

        //    //Student S1 = S[0];

        //    //var  enroll = new Enroll(S[0], C[0]);
        //    return e ;



        ////   a.enroll();
        //  return e;
        //Student[] S = new Student[1];
        //Course[] C = new Course[1];
        //a.enroll(S[0], C[0]);
        //Info i = new Info();
        //i.display(S[0], C[0]);


    }

}
