using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreApp01
{
    public static class ModelBuilderExtensions
    {
        public static void SeedEmpDB(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
               new Department { DId = 10, DName = "Software", Location = "USA" },
               new Department { DId = 20, DName = "Hardware", Location = "UK" }

               );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1001, EName = "Kiran", Job = "Trainer", Salary = 5000 },
                new Employee { Id = 1002, EName = "Raju", Job = "Developer", Salary = 6000 }
                );
        }
    }
    public class IncedoDbContext : DbContext
    {
        public IncedoDbContext(DbContextOptions<IncedoDbContext>options) : base(options)
        {

        }
        public DbSet<Employee> Employees{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedEmpDB();            
        }
    }
}
