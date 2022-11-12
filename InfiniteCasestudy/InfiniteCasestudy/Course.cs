using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCasestudy
{
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string Cduration { get; set; }
        public int Cfee { get; set; }


        public Course(int CId, string CName, string Cduration, int Cfee)
        {
            this.CId = CId;
            this.CName = CName;
            this.Cduration = Cduration;
            this.Cfee = Cfee;

        }
    }
}
