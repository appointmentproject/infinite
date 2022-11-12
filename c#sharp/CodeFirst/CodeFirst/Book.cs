using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    [Table("tbl_Book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}