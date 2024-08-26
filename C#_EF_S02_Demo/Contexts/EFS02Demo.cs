using C__EF_S02_Demo.Configurations;
using C__EF_S02_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Demo.Contexts
{
    public class EFS02Demo : DbContext
    {
        //To Connect Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = .;Database=EFS02Demo;Trusted_Connection=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            //Or
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
        //Names Table That In Database
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
