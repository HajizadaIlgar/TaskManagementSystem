using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                .IsRequired().
                HasMaxLength(32);
            builder.Property(e=>e.Surname)
                .IsRequired()
                .HasMaxLength(32);
        }
    }
}
