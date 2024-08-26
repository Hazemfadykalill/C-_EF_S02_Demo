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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           builder.HasKey(x => x.Id);
           builder.Property(x => x.Id).UseIdentityColumn(50,2);

            builder.Property(nameof(Department.Name)).
                IsRequired().HasColumnName("DepartmentName").
                HasColumnType("varchar").
                HasMaxLength(30);

            builder.HasOne(D => D.Manager).
                
                WithOne(E => E.Department).
                HasForeignKey<Department>(E=>E.EmpId);
        }
    }
}
