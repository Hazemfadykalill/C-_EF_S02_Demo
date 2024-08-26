using C__EF_S02_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Demo.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Define the primary key
            builder.HasKey(e => e.Id);
          

            // Define properties
            builder.Property(e => e.Id)
                   .UseIdentityColumn(10,10); // Auto-incrementing ID

            builder.Property(e => e.Name)
                .HasColumnType("varchar")
                   .IsRequired() // Make Name required
                   .HasMaxLength(100); // Set a maximum length for Name

            builder.Property(e => e.Address)
                   .HasMaxLength(200); // Set a maximum length for Address

            builder.Property(e => e.Salary)
                   .HasColumnType("decimal(18,2)"); // Set the Salary to be a decimal with precision

            builder.Property(e => e.Age)
                   .IsRequired();
            builder.HasOne(E => E.Department).
                WithOne(E => E.Manager).
                HasForeignKey<Department>(D=>D.EmpId);
               



        }
    }
}
