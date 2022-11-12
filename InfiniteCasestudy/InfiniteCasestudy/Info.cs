using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCasestudy
{
    public class Info : UserInterface
    {

        public void display(Student student)
        {
            Console.WriteLine("{0} \t {1} \t {2}", student.Sid, student.Sname, student.DOB.ToShortDateString());

        }


        public void Display(Course course)
        {

            Console.WriteLine("{0} \t {1} \t {2}\t{3}", course.CId, course.CName, course.Cduration, course.Cfee);
        }

        //public void display(Student student,Course course,LocalDate localDate)
        //{
        //    Console.WriteLine("{0}\t{1}\t{2}", student.name, course.Name,localDate.enrollmentdate);
        //}



    }


}


