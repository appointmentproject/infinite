using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }
        public string Authorname { get; set; }
    }
}
