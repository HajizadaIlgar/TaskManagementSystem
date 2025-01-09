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
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasMaxLength(64);
            builder
                 .Property(x => x.Description)
                 .IsRequired()
                 .HasColumnName("Description")
                 .HasMaxLength(256);
            builder
            .Property(x => x.CreatedDate)
            .HasDefaultValue(DateTime.Now);
        }
    }
}
