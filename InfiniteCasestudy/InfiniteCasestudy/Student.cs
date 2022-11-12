using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCasestudy
{
    public class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public DateTime DOB { get; set; }


        public Student(int Sid, string Sname, DateTime DOB)
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.DOB = DOB;
        }

    }

}
