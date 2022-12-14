//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataFirstcode
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sqlEntities2 : DbContext
    {
        public sqlEntities2()
            : base("name=sqlEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<sample> samples { get; set; }
    
        [DbFunction("sqlEntities2", "GetEmployeeByname")]
        public virtual IQueryable<GetEmployeeByname_Result> GetEmployeeByname(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetEmployeeByname_Result>("[sqlEntities2].[GetEmployeeByname](@did)", didParameter);
        }
    
        [DbFunction("sqlEntities2", "inlinetablefunc1")]
        public virtual IQueryable<inlinetablefunc1_Result> inlinetablefunc1(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<inlinetablefunc1_Result>("[sqlEntities2].[inlinetablefunc1](@did)", didParameter);
        }
    
        public virtual ObjectResult<FewEmployee_Result> FewEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FewEmployee_Result>("FewEmployee");
        }
    
        public virtual ObjectResult<getEmployeebyId_Result> getEmployeebyId(Nullable<int> eid)
        {
            var eidParameter = eid.HasValue ?
                new ObjectParameter("eid", eid) :
                new ObjectParameter("eid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmployeebyId_Result>("getEmployeebyId", eidParameter);
        }
    
        public virtual int getEmployeeSalary(string name, ObjectParameter sal)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getEmployeeSalary", nameParameter, sal);
        }
    
        public virtual int getMarks(string name, string sub)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var subParameter = sub != null ?
                new ObjectParameter("sub", sub) :
                new ObjectParameter("sub", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getMarks", nameParameter, subParameter);
        }
    
        public virtual int getno_ofemployees(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getno_ofemployees", didParameter);
        }
    
        public virtual ObjectResult<string> getno_ofemployees_new(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getno_ofemployees_new", didParameter);
        }
    
        public virtual ObjectResult<proc1_Result> proc1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc1_Result>("proc1");
        }
    }
}
