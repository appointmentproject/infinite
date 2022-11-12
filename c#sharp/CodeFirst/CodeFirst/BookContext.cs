using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class BookContext : DbContext
    {
        public BookContext() : base("name=Bookcontext")
        {
            Database.Log = Console.WriteLine;
        }

        //include all models as DbSet Objects
        public DbSet<Book> Books { get; set; }
        public DbSet<Publishers> Publisher { get; set; }
        public DbSet<Authors> Author { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                 .MapToStoredProcedures(s => s.Insert(a => a.HasName("InsertBook", "dbo"))
                                 .Update(a => a.HasName("UpdateBook", "dbo"))
                                 .Delete(a => a.HasName("DeleteBook", "dbo")));
        }
    }
}