using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL.Contexts;

public class TaskManagementSystemDbContext :DbContext
{
    public TaskManagementSystemDbContext(DbContextOptions opt) : base(opt) { }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Topic> Topics { get; set; }
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Assignment>()
             .HasMany(x => x.Tags)
             .WithMany(x => x.Assignments);
        modelBuilder
            .Entity<Assignment>()
                    .HasOne(x => x.Employee)
                    .WithMany(x => x.Assignments)
                    .HasForeignKey(x=>x.EmployeeId);
        modelBuilder
            .Entity<Assignment>()
            .HasOne(x=>x.Topic)
            .WithMany(x=>x.Assignments)
            .HasForeignKey(x=>x.TopicId);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementSystemDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
