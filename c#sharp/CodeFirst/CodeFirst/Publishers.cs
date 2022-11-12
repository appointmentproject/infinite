using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace CodeFirst
{
    public class Publishers
    {
        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
    }
}
