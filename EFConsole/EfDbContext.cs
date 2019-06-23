using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EFConsole.Order;

namespace EFConsole
{
    public class EfDbContext : DbContext
    {

        public EfDbContext() : base("name=ConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfDbContext>());
        }
        public DbSet<Blog> Blogs
        {
            get
            {
                return Set<Blog>();

            }
        }


        public DbSet<Department> Departments
        {
            get
            {
                return Set<Department>();

            }
        }

        public DbSet<Course> Courses
        {
            get
            {
                return Set<Course>();

            }
        }

        public DbSet<Order> Orders
        {
            get
            {
                return Set<Order>();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>().ToTable("BB");
            //modelBuilder.Entity<Order>().ToTable("Orders");
            //modelBuilder.ComplexType<Address>();
            //base.OnModelCreating(modelBuilder);

          
        }
    }
}
